using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ResturantMenu.Shared;

namespace ResturantMenu.Main.Services
{
    public class OrderDataService : IOrderDataService
    {
        private readonly HttpClient _httpClient;

        public OrderDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Order>> Get()
        {
            return await JsonSerializer.DeserializeAsync<List<Order>>
                (await _httpClient.GetStreamAsync($"api/order"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Order> Get(int orderId)
        {
            return await JsonSerializer.DeserializeAsync<Order>
                (await _httpClient.GetStreamAsync($"api/order/{orderId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Order> Add(Order order)
        {
            var orderJson =
                new StringContent(JsonSerializer.Serialize(order), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/order", orderJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<Order>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }
    }
}