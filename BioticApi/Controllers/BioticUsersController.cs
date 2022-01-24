using BioticApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BioticApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BioticUsersController : ControllerBase
    {
        private readonly BioticDbContext _context;
        public BioticUsersController(BioticDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public 
    }
}
