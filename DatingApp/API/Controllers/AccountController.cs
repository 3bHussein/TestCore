using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
//new 
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace API.Controllers
{
    public class AccountController :BaseApiController
    {
        
        private readonly DataContext _context;
        public AccountController (DataContext context)
        {
            _context =context;
        }

        [HttpPost("register")]
        public async Task<ActionResult<AppUser>> register(string username,string password){
            var hmac =new HMACSHA512();
           
            var user =new AppUser{
                UserName =username,
                PasswordHash =hmac.ComputeHash(Encoding.UTF8.GetBytes(password)),
                PasswordSalt =hmac.Key
            };
        _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}