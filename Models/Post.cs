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
		public string? Img_Url { get; set; }
		public string? PostTittle { get; set; }
        public string? PostContent { get; set; }
        public DateTime? TimeStamp { get; set; }
        public string? Location { get; set; }
        public string? DeviceIpv4 { get; set; }
        public bool? IsReviewed { get; set; }
    }
    public class PostView
    {
        public Guid Post_Id { get; set; }
        public Guid Category_Id { get; set; }
        public Guid City_Id { get; set; }
        public Guid Governrate_Id { get; set; }
        public Guid Status_Id { get; set; }
        public string City { get; set; }
        public Guid User_Id { get; set; }
        public string Governrate { get; set; }
        public string Status { get; set; }
        public string Category { get; set; }
        public string? Post_Tittle { get; set; }
        public string? Post_Content { get; set; }
        public DateTime? Time_Stamp { get; set; }
        public string? Img_Url { get; set; }
        public string? Location { get; set; }
        public string? Device_Ipv4 { get; set; }
        public bool? Is_Reviewed { get; set; }
    }
    public class PostResponse : BaseDto
    {
        public List<PostView>? Data { get; set; }
    }
}
