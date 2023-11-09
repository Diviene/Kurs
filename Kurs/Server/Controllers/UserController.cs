using Kurs.Client.Pages;
using Kurs.Server.Data;
using Kurs.Shared.Models;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kurs.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            var list = await _context.Users.ToListAsync();
            return new JsonResult(list);
        }

        [HttpGet]
        [Route("{UserId}")]

        public async Task<ActionResult<User>> GetUserById(int UserId)
        {
            var user = _context.Users.FirstOrDefault(c => c.UserId == UserId);
            if (user == null)
            {
                return NotFound("Пользователь не найден");
            }
            else 
            { 
                return Ok(user);
            }
        }
    }
}
