using System.Text.Json.Serialization;

namespace BlazorApp1.Web.Models
{
    public class ProductResponse
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("imageURL")]
        public string ImageURL { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        [JsonPropertyName("categoryId")]
        public Guid CategoryId { get; set; }
    }
}
