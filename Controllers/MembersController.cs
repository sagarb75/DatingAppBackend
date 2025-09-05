using DatingApp.Data;
using DatingApp.Entity;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MembersController : ControllerBase
    {
        private readonly AppDbContext context;
        public MembersController(AppDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult GetMembers()
        {
            var members = context.Users.ToList();
            return Ok(members);
        }
        [HttpGet("{id}")]
        public IActionResult GetMember([FromRoute] Guid id)
        {
            var member = context.Users.Find(id);
            if (member == null) return NotFound();
            return Ok(member);
        }
    }
}
