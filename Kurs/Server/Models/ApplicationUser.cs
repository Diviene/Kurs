using Kurs.Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Kurs.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? CustomerSurName { get; set; }

        public string? CustomerName { get; set; }

        public string? CustomerPatronymic { get; set; }

        [Column(TypeName = "timestamp without time zone")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        public string? Gender { get; set; }

        public int Phone { get; set; }

        public int PassportSeries { get; set; }

        public int PassportNumber { get; set; }

        public string? AddressLine1 { get; set; }

        public string? AddressLine2 { get; set; }

        public int? Passport
        {

            get
            {
                return int.Parse(PassportSeries.ToString() + " " +
                         PassportNumber.ToString()); ;
            }
        }

        public string? Address
        {
            get 
            { 
            return AddressLine1 + " " + AddressLine2;
            }
        }

    }
}
