using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Shared.Models
{
    public class Hotel
    {
        public int HotelId { get; set; }

        public string? HotelName { get; set; }

        public string? HotelAddress { get; set; }

        public int HotelPostcode { get; set; }

        public string? HotelUrl { get; set; }

        public bool? IsPet { get; set; }

        public string? HotelDescription { get; set; }

        public int CityId { get; set; }

        public City? City { get; set; }

        public int HotelChainId { get; set; }

        public HotelChain? HotelChain { get; set; }

        public int HotelRatingId { get; set; }

        public HotelRating? HotelRating { get; set; }
    }
}
