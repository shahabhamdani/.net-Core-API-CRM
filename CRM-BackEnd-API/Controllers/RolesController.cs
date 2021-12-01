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
    public class RolesController : ControllerBase
    {

        private eversrty_CRMDBContext db = new eversrty_CRMDBContext();


        [HttpGet]
        public IActionResult GetRoles()
        {

            var temp = db.UserRoles.ToList();
            return Ok(temp);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetRoles(int id)
        {

            var temp = db.UserRoles.Where(_ => _.UserRolesId == id).FirstOrDefault();
            return Ok(temp);
        }

        [HttpPost]
        public IActionResult CreateRole(UserRoles temp)
        {
            db.Add(temp);
            db.SaveChanges();
            return Ok(temp.UserRolesId);

        }

        [HttpPut]
        public IActionResult UpdateRole(UserRoles temp)
        {

            db.Update(temp);
            db.SaveChanges();

            return NoContent();
        }


        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteRole(int id)
        {

            var temp = db.UserRoles.Where(_ => _.UserRolesId == id).FirstOrDefault();
            if (temp == null)
            {
                return NotFound();
            }


            db.UserRoles.Remove(temp);
            db.SaveChanges();
            return NoContent();

        }

    }
}
