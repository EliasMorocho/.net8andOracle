namespace Admin.Application.DTOs.Accounts
{
    public class AccountListResponse
    {
        public string Token { get; set; }
        public List<AccountDTO> Accounts { get; set; }
    }
}