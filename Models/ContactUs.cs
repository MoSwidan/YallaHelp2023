namespace YallaHelpWeb.Shared
{
    public class ContactUs
    {
        public Guid Message_Id { get; set; }
        public Guid User_Id { get; set; }
        public DateTime? TimeStamp { get; set; }
        public string? Content { get; set; }
    }
}
