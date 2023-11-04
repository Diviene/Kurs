using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Shared.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }

        public DateTime? DateOfStart { get; set; }

        public DateTime? DateOfEnd { get; set; }

        public int NumberOfPeople { get; set; }

        public int FullPrice { get; set; }

        public string GetFormattedFullPrice() => FullPrice.ToString("0.00");

        public int CustomerId { get; set; }

        public Customer? Customer { get; set; }

        public int HotelRoomTypeId { get; set; }

        public HotelRoomType? HotelRoomType { get; set; }
    }
}
