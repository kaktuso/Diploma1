using System.Net.Http.Json;
using Diploma1.Web.Models;

namespace Diploma1.Web.Services
{
    public class EmployeeService
    {
        private readonly HttpClient _http;
        public EmployeeService(HttpClient http) => _http = http;

        public async Task<List<EmployeeDto>?> GetAllAsync() =>
            await _http.GetFromJsonAsync<List<EmployeeDto>>("api/Employee");

        public async Task<EmployeeDto?> GetByIdAsync(Guid id) =>
            await _http.GetFromJsonAsync<EmployeeDto>($"api/Employee/{id}");

        public async Task CreateAsync(EmployeeDto dto) =>
            await _http.PostAsJsonAsync("api/Employee", dto);

        public async Task UpdateAsync(Guid id, EmployeeDto dto) =>
            await _http.PutAsJsonAsync($"api/Employee/{id}", dto);

        public async Task DeleteAsync(Guid id) =>
            await _http.DeleteAsync($"api/Employee/{id}");
    }
}