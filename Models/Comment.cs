namespace YallaHelpWeb.Shared
{
    public class Comment
    {
        public Guid Comment_Id { get; set; }
        public Guid? Post_Id { get; set; }
        public Guid? User_Id { get; set; }
        public string? Comment_Content { get; set; }
        public string? TimeStamp { get; set; }
    }
    public class CommentView : Comment
    {
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public string? Image_Url { get; set; }
    }
    public class CommentResponse : BaseDto
    {
        public List<CommentView>? Data { get; set; }
    }
}
