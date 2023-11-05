using Kurs.Shared.Models;
using Microsoft.AspNetCore.Identity;

namespace Kurs.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        List<Customer> Customers { get; set; } = new List<Customer>();
    }
}