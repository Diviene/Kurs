using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Shared.Models
{
    public class Hotel
    {
        [Key]
        public int hotelId { get; set; }

        public string? hotelName { get; set; }

        public string? hotelAddress { get; set; }

        public int hotelPostcode { get; set; }

        public string? hotelUrl { get; set; }

        public bool? isPet { get; set; }

        public string? hotelDescription { get; set; }

        public int cityId { get; set; }

        public City? city { get; set; }

        public int hotelChainId { get; set; }

        public HotelChain? hotelChain { get; set; }

        public int hotelRatingId { get; set; }

        public HotelRating? hotelRating { get; set; }
    }
}
