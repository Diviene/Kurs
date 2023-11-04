using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Shared.Models
{
    public class HotelRating
    {
        public int HotelRatingId { get; set; }

        public string? HotelRatingStars { get; set; }

        public ICollection<Hotel>? Hotels { get; set; }
    }
}
