using Microsoft.AspNetCore.Mvc;
using rest_api.Auth;
using rest_api.Data;
using rest_api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rest_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly DataContext _context;

        public LoginController(DataContext context)
        {
            _context = context;
        }

        // POST: api/Login
        [HttpPost]
        public ActionResult PostLogin(BodyLogin body)
        {
            User user = _context.Users.ToList().Find(x => x.Username.Equals(body.Username));
            if (TokenManager.VerifyPassword(body.Password, user.Hash, user.Salt))
                return Ok(TokenManager.generateToken(body.Username));
            else
                return Unauthorized();
        }
    }

    public class BodyLogin
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
