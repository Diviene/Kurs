using Kurs.Server.Data;
using Kurs.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kurs.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CityController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<List<City>>> GetAllHotels()
        {
            var list = await _context.Cities.ToListAsync();

            return Ok(list);
        }
    }
}
