using Duende.IdentityServer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Duende.IdentityServer.EntityFramework.Options;
using Kurs.Server.Models;
using Kurs.Shared;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Kurs.Server.Data;
using Kurs.Client.Pages;
using Microsoft.AspNetCore.Authorization;
using Kurs.Shared.Models;

namespace Kurs.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public HotelController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Hotel>>> GetAllHotels(CancellationToken cancellationToken = default)
        {
            var list = await _context.Hotels.ToListAsync(cancellationToken);

            return Ok(list);
        }
    }
}
