namespace YallaHelpWeb.Shared
{
    public class Favorite
    {
        public Guid Favorite_Id { get; set; }
        public Guid User_Id { get; set; }
        public Guid Post_Id { get; set; }
        public DateTime? TimeStamp { get; set; }
    }
}
