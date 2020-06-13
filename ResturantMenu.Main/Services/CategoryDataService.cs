using ResturantMenu.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ResturantMenu.Main.Services
{
    public class CategoryDataService: ICategoryDataService
    {
        private readonly HttpClient _httpClient;

        public CategoryDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Category>> Get()
        {
            return await JsonSerializer.DeserializeAsync<List<Category>>
                (await _httpClient.GetStreamAsync($"api/category"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Category> Get(int categoryId)
        {
            return await JsonSerializer.DeserializeAsync<Category>
                (await _httpClient.GetStreamAsync($"api/category/{categoryId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Category> Add(Category category)
        {
            var categoryJson =
                new StringContent(JsonSerializer.Serialize(category), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/category", categoryJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<Category>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        public async Task Update(Category category)
        {
            var categoryJson =
                new StringContent(JsonSerializer.Serialize(category), Encoding.UTF8, "application/json");

            await _httpClient.PutAsync("api/category", categoryJson);
        }

        public async Task Delete(int categoryId)
        {
            await _httpClient.DeleteAsync($"api/category/{categoryId}");
        }
    }
}
