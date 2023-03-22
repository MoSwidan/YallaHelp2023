namespace YallaHelpWeb.Shared
{
    public class SpecialPost
    {
        public Guid SpecialPost_Id { get; set; }
        public Guid Post_Id { get; set; }
        public DateTime? TimeStamp { get;set;}
        public DateTime? PostExpire { get; set; }
    }
}
