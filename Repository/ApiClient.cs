using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using InventoryShipmentManagement.Models;
using Newtonsoft.Json;

public class ApiClient
{
    private readonly HttpClient _httpClient;
    private HttpClient httpClient;

    public ApiClient(string baseUrl)
    {
        _httpClient = new HttpClient { BaseAddress = new Uri(baseUrl) };
    }

    public ApiClient(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<List<InventoryItem>> GetInventoryItemsAsync()
    {
        var response = await _httpClient.GetAsync("https://localhost:7063/api/InventoryItem");
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<List<InventoryItem>>(content);
    }

    public async Task AddInventoryItemAsync(InventoryItem item)
    {
        var response = await _httpClient.PostAsJsonAsync("https://localhost:7063/api/InventoryItem", item);
        response.EnsureSuccessStatusCode();
    }

    public async Task UpdateInventoryItemAsync(InventoryItem item)
    {
        var response = await _httpClient.PutAsJsonAsync($"https://localhost:7063/api/InventoryItem/{item.Id}", item);
        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteInventoryItemAsync(int id)
    {
        var response = await _httpClient.DeleteAsync($"https://localhost:7063/api/InventoryItem/{id}");
        response.EnsureSuccessStatusCode();
    }

    public async Task<List<InventoryItem>> GetExportInventoryItemsAsync()
    {
        string apiUrl = "https://localhost:7063/api/InventoryItem";
        // Replace with your API URL
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                List<InventoryItem> inventoryItems = JsonConvert.DeserializeObject<List<InventoryItem>>(jsonResponse);
                return inventoryItems;
            }
            else
            {
                throw new Exception("API request failed");
            }
        }
    }
}
