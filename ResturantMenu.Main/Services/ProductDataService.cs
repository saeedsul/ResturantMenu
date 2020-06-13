using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ResturantMenu.Shared;

namespace ResturantMenu.Main.Services
{
    public class ProductDataService : IProductDataService
    {
        private readonly HttpClient _httpClient;

        public ProductDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Product>> Get()
        {
            return await JsonSerializer.DeserializeAsync<List<Product>>
                (await _httpClient.GetStreamAsync($"api/product"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Product> Get(int productId)
        {
            return await JsonSerializer.DeserializeAsync<Product>
                (await _httpClient.GetStreamAsync($"api/product/{productId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Product> Add(Product product)
        {
            var productJson =
                new StringContent(JsonSerializer.Serialize(product), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/product", productJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<Product>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        public async Task Update(Product product)
        {
            var productJson =
                new StringContent(JsonSerializer.Serialize(product), Encoding.UTF8, "application/json");

            await _httpClient.PutAsync("api/product",productJson);
        }

        public async Task Delete(int productId)
        {
            await _httpClient.DeleteAsync($"api/product/{productId}");
        }
    }
}