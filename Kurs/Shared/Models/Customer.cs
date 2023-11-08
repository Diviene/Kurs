using Kurs.Shared.Models;

namespace Kurs.Shared.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string? CustomerSurname { get; set; }

        public string? CustomerName { get; set; }

        public string? CustomerPatronymic { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public bool CustomerGender { get; set; }

        public string? CustomerPhone { get; set; }

        public ICollection<Reservation>? Reservations { get; set; }

        public string FullName
        {
            get
            {
                return CustomerSurname + " " +CustomerName + " " + CustomerPatronymic;

            }
         }
    }
}
