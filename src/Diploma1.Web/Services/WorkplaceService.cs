using System.Net.Http.Json;
using Diploma1.Web.Models;

namespace Diploma1.Web.Services
{
    public class WorkplaceService
    {
        private readonly HttpClient _http;
        public WorkplaceService(HttpClient http) => _http = http;

        public async Task<List<WorkplaceDto>?> GetAllAsync() =>
            await _http.GetFromJsonAsync<List<WorkplaceDto>>("api/Workplace");

        public async Task<WorkplaceDto?> GetByIdAsync(Guid id) =>
            await _http.GetFromJsonAsync<WorkplaceDto>($"api/Workplace/{id}");

        public async Task CreateAsync(WorkplaceDto dto) =>
            await _http.PostAsJsonAsync("api/Workplace", dto);

        public async Task UpdateAsync(Guid id, WorkplaceDto dto) =>
            await _http.PutAsJsonAsync($"api/Workplace/{id}", dto);

        public async Task DeleteAsync(Guid id) =>
            await _http.DeleteAsync($"api/Workplace/{id}");
    }
}