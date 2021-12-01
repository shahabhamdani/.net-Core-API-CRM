


using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRM_BackEnd_API.Models;

namespace CRM_BackEnd_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {

        private eversrty_CRMDBContext db = new eversrty_CRMDBContext();


        [HttpGet]
        public IActionResult GetUsers()
        {

            var temp = db.Users.ToList();
            return Ok(temp);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetUsers(int id)
        {

            var temp = db.Users.Where(_ => _.UserId == id).FirstOrDefault();
            return Ok(temp);
        }

        [HttpPost]
        public IActionResult CretaeUser(Users temp)
        {
            db.Add(temp);
            db.SaveChanges();
            return Ok(temp.UserId);

        }

        [HttpPut]
        public IActionResult UpdateUser( Users user)
        {
           
            db.Update(user);
            db.SaveChanges();

            return NoContent();
        }


        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteUser(int id)
        {

            var temp = db.Users.Where(_ => _.UserId == id).FirstOrDefault();
            if (temp == null)
            {
                return NotFound();
            }


            db.Users.Remove(temp);
            db.SaveChanges();
            return NoContent();

        }

    }
}
