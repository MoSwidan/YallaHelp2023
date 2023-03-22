namespace YallaHelpWeb.Shared
{
    public class Comment
    {
        public Guid Comment_Id { get; set; }
        public Guid Post_Id { get; set; }
        public Guid User_Id { get; set; }
        public string? CommentContent { get; set; }
        public DateTime? TimeStamp { get; set; }
    }
}
