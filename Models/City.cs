﻿namespace YallaHelpWeb.Shared
{
    public class City
    {
        public Guid City_Id { get; set; }
        public Guid Governorate_Id { get; set; }
        public string? Name { get; set; }
    }
    public class CityResponse : BaseDto
    {
        public List<City>? Data { get; set; }
    }
}
