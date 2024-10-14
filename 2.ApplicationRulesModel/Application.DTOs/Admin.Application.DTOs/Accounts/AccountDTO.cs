namespace Admin.Application.DTOs.Accounts
{
    public class AccountDTO
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool State { get; set; }
        public string Role { get; set; }
    }
}