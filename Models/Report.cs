namespace YallaHelpWeb.Shared
{
    public class Report
    {
        public Guid Report_Id { get; set; }
        public Guid User_Id { get; set; }
        public Guid Post_Id { get; set; }
        public string? Content { get; set; }
    }
}
