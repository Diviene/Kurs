using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Shared.Models
{
    public class User
    {
            public int UserId { get; set; }

            public string? CustomerSurname { get; set; }

            public string? CustomerName { get; set; }

            public string? CustomerPatronymic { get; set; }

            [DataType(DataType.Date)]
            [Column(TypeName = "timestamp without time zone")]
            public DateTime? DateOfBirth { get; set; }

            public string? CustomerGender { get; set; }
            

            public string? CustomerPhone { get; set; }


            public ICollection<Reservation>? Reservations { get; set; }

            public string FullName
            {
                get
                {
                    return CustomerSurname + " " + CustomerName + " " + CustomerPatronymic;

                }
            }
        }
    }
