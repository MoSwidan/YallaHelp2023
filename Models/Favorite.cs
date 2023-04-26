namespace YallaHelpWeb.Shared
{
    public class Favorite
    {
        public Guid Favorite_Id { get; set; }
        public Guid? User_Id { get; set; }
        public Guid? Post_Id { get; set; }
        public string? TimeStamp { get; set; }
    }
}
