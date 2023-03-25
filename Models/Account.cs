namespace YallaHelpWeb.Shared
{
    public class Account
    {
        public Guid? Account_Id { get; set; }
        public Guid? User_Id { get; set; }
        public string? Email { get; set; }
        public string? Phone_Number { get; set; }
        public string? Password { get; set; }
    }
	public class AccountResponse
	{
		public string? Meassage { get; set; }
		public string? Code { get; set; }
		public Account? Data { get; set; }
	}
}
