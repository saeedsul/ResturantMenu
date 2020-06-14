using ResturantMenu.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

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
            using var response = await _httpClient.GetAsync("api/category");
            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<Category>>(content);
        }

        public async Task<Category> Get(int categoryId)
        {
            using var response = await _httpClient.GetAsync($"api/category/{categoryId}");
            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Category>(content);
        }

        public async Task<CategoryModel> Add(Category category)
        {
            var categoryJson =
                new StringContent(JsonSerializer.Serialize(category), Encoding.UTF8, "application/json");

            using var response = await _httpClient.PostAsync("api/category", categoryJson);
            var content = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<CategoryModel>(content);

            var errorKeyPair = JsonConvert.DeserializeObject<Dictionary<string, string[]>>(content);

            var errors = errorKeyPair.Select(
                item =>
                    new ApiError
                    {
                        FieldName = item.Key,
                        Description = item.Value.ToList().FirstOrDefault()
                    }).ToList();

            return new CategoryModel
            {
                Errors = errors
            };
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
