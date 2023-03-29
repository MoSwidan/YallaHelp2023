namespace YallaHelpWeb.Shared
{
    public class Status
    {
        public Guid Status_Id { get; set; }
        public string? Name { get; set; }
    }
    public class StatusResponse : BaseDto
    {
        public List<Status>? Data { get; set; }
    }
}
