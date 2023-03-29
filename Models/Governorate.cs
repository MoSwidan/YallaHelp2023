namespace YallaHelpWeb.Shared
{
    public class Governorate
    {
        public Guid Governorate_Id { get; set; }
        public string? Name { get; set; }
    }
    public class GovernorateResponse : BaseDto
    {
        public List<Governorate>? Data { get; set; }
    }
}
