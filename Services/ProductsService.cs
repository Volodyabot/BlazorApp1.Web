using BlazorApp1.Web.Models;
using System.Text.Json;
using System.Text;

namespace BlazorApp1.Web.Services
{
    public class ProductsService
    {
        private readonly HttpClient _httpClient;

        public ProductsService(HttpClient httpClient)
        {
            _httpClient = httpClient;

            httpClient.BaseAddress = new Uri("https://localhost:7128");
        }


        public Task<IEnumerable<ProductResponse>> Get()
        {
            return _httpClient.GetFromJsonAsync<IEnumerable<ProductResponse>>($"/api/products");
        }

        public Task<IEnumerable<ProductResponse>> Get(string term)
        {
            return _httpClient.GetFromJsonAsync<IEnumerable<ProductResponse>>($"/api/products?term={term}");
        }

        public Task<ProductResponse> Get(Guid id)
        {
            return _httpClient.GetFromJsonAsync<ProductResponse>($"/api/products/{id}");
        }

        public async Task AddProduct(ProductDto productDto)
        {
            // Send the product data to the server using HTTP POST
            await _httpClient.PostAsync("api/products", new StringContent(JsonSerializer.Serialize(productDto), Encoding.UTF8, "application/json"));
        }

        // DELETE
        public async Task DeleteProduct(Guid id)
        {
            // Send the DELETE request to the server
            await _httpClient.DeleteAsync($"/api/products/{id}");
        }
    }
}
