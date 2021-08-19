using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

//
using API.Data;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    // [Route("api/Controllers")]
    [Route("[controller]")]

    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>>GetUsers(){
            return  await  _context.Users.ToListAsync();

        }

        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUsers(int id ){
            return _context.Users.Find(id);
        }





 
    }
}