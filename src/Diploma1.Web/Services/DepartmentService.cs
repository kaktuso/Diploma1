using System.Net.Http.Json;
using Diploma1.Web.Models;

namespace Diploma1.Web.Services
{
    public class DepartmentService
    {
        private readonly HttpClient _http;
        public DepartmentService(HttpClient http) => _http = http;

        public async Task<List<DepartmentDto>?> GetAllAsync() =>
            await _http.GetFromJsonAsync<List<DepartmentDto>>("api/Department");

        public async Task<DepartmentDto?> GetByIdAsync(Guid id) =>
            await _http.GetFromJsonAsync<DepartmentDto>($"api/Department/{id}");

        public async Task CreateAsync(DepartmentDto dto) =>
            await _http.PostAsJsonAsync("api/Department", dto);

        public async Task UpdateAsync(Guid id, DepartmentDto dto) =>
            await _http.PutAsJsonAsync($"api/Department/{id}", dto);

        public async Task DeleteAsync(Guid id) =>
            await _http.DeleteAsync($"api/Department/{id}");
    }
}