using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ResturantMenu.Shared;
using JsonSerializer = System.Text.Json.JsonSerializer;

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
            using var response = await _httpClient.GetAsync("api/product");
            var content = await response.Content.ReadAsStringAsync();
                
            return JsonConvert.DeserializeObject<List<Product>>(content);
        }

        public async Task<Product> Get(int productId)
        {
            using var response = await _httpClient.GetAsync($"api/product/{productId}");
            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Product>(content);
        }

        public async Task<ProductModel> Add(Product product)
        {
            var productJson =
                new StringContent(JsonSerializer.Serialize(product), Encoding.UTF8, "application/json");

            using var response = await _httpClient.PostAsync("api/product", productJson);
            var content = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<ProductModel>(content);

            var errorKeyPair = JsonConvert.DeserializeObject<Dictionary<string, string []>>(content);
                   
            var errors = errorKeyPair.Select(
                item => 
                    new ApiError
                    {
                        FieldName = item.Key, 
                        Description = item.Value.ToList().FirstOrDefault()
                    }).ToList();

            return new ProductModel
            {
                Errors = errors
            };
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

    public class ApiException : Exception
    {
        public bool IsSuccess { get; set; }
        public int StatusCode { get; set; }
        public List<ApiError> Errors { get; set; } = new List<ApiError>();
    }

    public class ProductModel : ApiException
    {
        public Product Product { get; set; }
    }

    public class CategoryModel : ApiException
    {
        public Category Category { get; set; }
    }
    public sealed class ApiError
    {
        public ApiError()
        {
        }
        public ApiError(string code, string description)
        {
            Code = code;
            Description = description;
        }

        public ApiError(string code, string fieldName, string description)
        {
            Code = code;
            FieldName = fieldName;
            Description = description;
        }

        public string Code { get; set; }

        public string Description { get; set; }

        public string ResourceName { get; set; }

        public string FieldName { get; set; }
    }
}