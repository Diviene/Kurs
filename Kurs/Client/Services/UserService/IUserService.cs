using Kurs.Shared.Models;

namespace Kurs.Client.Services.UserService
{
    public  interface IUserService
    {

        List<User> Users { get; set; }

        Task GetUsers();

        Task<User> GetUserById (int id);

    }
}
