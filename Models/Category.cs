﻿namespace YallaHelpWeb.Shared
{
    public class Category
    {
        public Guid Category_Id { get; set; }
        public string? Name { get; set; }
    }
    public class CategoryResponse : BaseDto
    {
        public List<Category>? Data { get; set; }
    }
}
