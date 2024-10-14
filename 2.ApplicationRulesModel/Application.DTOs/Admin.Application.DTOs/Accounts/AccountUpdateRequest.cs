namespace Admin.Application.DTOs.Accounts
{
    public class AccountUpdateRequest
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int State { get; set; }
        public string Role { get; set; }
    }
}