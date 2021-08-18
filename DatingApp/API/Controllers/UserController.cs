using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

//
using API.Data;
using API.Entities;
 
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
        public ActionResult<IEnumerable<AppUser>>GetUsers(){
            return _context.Users.ToList();

        }

        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUsers(int id ){
            return _context.Users.Find(id);
        }






 
    }
}