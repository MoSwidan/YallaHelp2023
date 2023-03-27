namespace YallaHelpWeb.Shared
{
    public class User
    {
        public Guid? User_Id { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public char? Gender { get; set; }
        public string? Image_Url { get; set; }
        public DateTime? Date_Of_Join { get; set; }
        public bool? Is_Admin { get; set; }
    }
    public class UserResponse
    {
        public string? Meassage { get; set; }
        public string? Code { get; set; }
        public User? Data { get; set; }
    }
}
