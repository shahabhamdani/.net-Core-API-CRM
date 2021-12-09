


using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRM_BackEnd_API.Models;
using Microsoft.EntityFrameworkCore;

namespace CRM_BackEnd_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {

        private eversrty_CRMDBContext db = new eversrty_CRMDBContext();


        [HttpPost]
        public IActionResult GetUserInfo(Login login)
        {

            IList<Users> users =
            db.Users
              .Where(c => c.UserName == login.username && c.Password == login.password).Include(c=>c.UserRoles)
              .ToList();

            if(users.Count > 0)
            {
                return Ok(users);
            }
            else
            {
                return NoContent();

            }


        }

    }
}
