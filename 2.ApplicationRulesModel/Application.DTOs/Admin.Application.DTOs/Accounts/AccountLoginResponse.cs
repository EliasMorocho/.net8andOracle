namespace Admin.Application.DTOs.Accounts
{
    public class AccountLoginResponse
    {
        public string Username { get; set; }
        public bool IsLogin { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}