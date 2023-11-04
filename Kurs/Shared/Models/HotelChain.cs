using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Shared.Models
{
    public class HotelChain
    {
        public int HotelChainId { get; set; }

        public string? HotelChainName { get; set; }

        public string? HotelChainDescription { get; set; }

        public ICollection<Hotel>? Hotels { get; set; }
    }
}
