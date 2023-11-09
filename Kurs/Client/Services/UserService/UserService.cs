using Kurs.Shared.Models;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;

namespace Kurs.Client.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<User> Users { get; set; } = new List<User>();

        public HttpClient Http { get; }

        public async Task GetUsers()
        {
            var result = await _httpClient.GetFromJsonAsync<List<User>>("api/User");
            if (result != null)
                Users = result;
        }

        public Task<User> GetUserById(int id)
        { 
            throw new NotImplementedException();
        }
    }
}
