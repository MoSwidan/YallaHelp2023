namespace YallaHelpWeb.Shared
{
    public class Like
    {
        public Guid Like_Id { get; set; }
        public Guid Post_Id { get; set; }
        public Guid? User_Id { get; set; }
        public string? TimeStamp { get; set; }
    }
    public class LikeResponse : BaseDto
    {
        public List<Like>? Data { get; set; }
    }
}
