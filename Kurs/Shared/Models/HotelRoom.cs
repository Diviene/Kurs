using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Shared.Models
{
    public class HotelRoom
    {
        public int HotelRoomId { get; set; }

        public int HotelRoomNumber { get; set; }

        public int HotelRoomFloor { get; set; }

        public int HotelRoomCount { get; set; }

        public int HotelId { get; set; }

        public Hotel? Hotel { get; set; }

        public int HotelRoomTypeId { get; set; }

        public HotelRoomType? HotelRoomType { get; set; }
    }
}
