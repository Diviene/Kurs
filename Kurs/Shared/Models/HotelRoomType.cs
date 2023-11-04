using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Shared.Models
{
    public class HotelRoomType
    {
        public int HotelRoomTypeId { get; set; }

        public int Rating { get; set; }

        public int PriceForPerson { get; set; }

        public bool IsFood { get; set; }

        public ICollection<Reservation>? Reservations { get; set; }

        public ICollection<HotelRoom>? HotelRooms { get; set; }
    }
}
