namespace YallaHelpWeb.Shared
{
    public class Post
    {
        public Guid Post_Id { get; set; }
        public Guid City_Id { get; set; }
        public Guid User_Id { get; set; }
        public Guid Governrate_Id { get; set; }
        public Guid Status_Id { get; set; }
        public Guid Category_Id { get; set; }
        public string? Post_Tittle { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public string? Post_Content { get; set; }
        public string? Img_Url { get; set; }
        public string? Time_Stamp { get; set; }
        public string? Device_Ipv4 { get; set; }
        public bool? Is_Reviewed { get; set; }
    }
    public class PostView : Post
    {
        public string? Governrate { get; set; }
        public string? Status { get; set; }
        public string? Category { get; set; }
        public Guid Favorite_id { get; set; }
        public string? City { get; set; }
    }
    public class PostResponse : BaseDto
    {
        public List<PostView>? Data { get; set; }
    }
    public class PostDetailsResponse : BaseDto
    {
        public PostViewDetails? Data { get; set; }
    }
    public class PostViewDetails : PostView
    {
        public string? Image_Url { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public string? Phone_Number { get; set; }
        public string? Email { get; set; }
    }
}
