using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Admin.Application.DTOs.Accounts;
using Admin.Application.IControllers.Accounts;

namespace Admin.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController(
        ILogger<AccountController> logger,
        IAccountLoginController accountLoginController,
        IAccountListController accountListController,
        IAccountRegisterController accountRegisterController,
        IAccountByIdController accountByIdController,
        IAccountUpdateController accountUpdateController,
        IConfiguration configuration) : ControllerBase
    {
        private readonly ILogger<AccountController> _logger = logger;
        private readonly IAccountLoginController _accountLoginController = accountLoginController;
        private readonly IAccountListController _accountListController = accountListController;
        private readonly IAccountRegisterController _accountRegisterController = accountRegisterController;
        private readonly IAccountByIdController _accountByIdController = accountByIdController;
        private readonly IAccountUpdateController _accountUpdateController = accountUpdateController;
        private readonly string _jwtSecret = configuration["Jwt:Secret"];

        
        [HttpPost("register")]
        public async Task<ActionResult<string>> Register(AccountRegisterRequest request)
        {
            var response = await _accountRegisterController.Handle(request);
            if (response.Status)
            {
                return Ok(response);
            }
            return BadRequest(response.Message);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AccountByIdResponse>> GetById(string id)
        {
            var response = await _accountByIdController.Handle(new AccountByIdRequest { Id = id });
            if (response.Account == null)
            {
                return NotFound();
            }
            return Ok(response.Account);
        }

      

        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(AccountLoginRequest request)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Invalid login attempt with model state errors.");
                return BadRequest(ModelState);
            }

            var account = await _accountLoginController.Handle(request);
            if (!account.IsLogin)
            {
                return Unauthorized("Invalid username or password.");
            }

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, account.Username),
                new Claim(ClaimTypes.Email, account.Email),
                new Claim(ClaimTypes.Role, account.Role)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSecret));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                issuer: null,
                audience: null,
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds);

            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);
            _logger.LogInformation("User {Username} logged in successfully.", request.Email);

            return Ok(new { Token = tokenString });
        }

        
    }
}
