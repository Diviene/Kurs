using Kurs.Shared.Models;

namespace Kurs.Shared.Models
{
    public class City
    {
        public int CityId { get; set; }

        public string? CityName { get; set; }

        public ICollection<Hotel>? Hotels { get; set; }

    }
}
