﻿namespace BlazorApp1.Web.Models
{
    public class ProductDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }
        public Guid CategoryId { get; set; }
    }
}
