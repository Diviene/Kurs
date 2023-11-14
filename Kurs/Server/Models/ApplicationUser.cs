using Kurs.Shared.Models;
using Microsoft.AspNetCore.Identity;

namespace Kurs.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? CustomerSurName { get; set; }

        public string? CustomerName { get; set; }

        public string? CustomerPatronymic { get; set; }
    }
}