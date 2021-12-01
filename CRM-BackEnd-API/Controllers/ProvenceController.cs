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
    public class ProvenceController : ControllerBase
    {

        private eversrty_CRMDBContext db = new eversrty_CRMDBContext();


        [HttpGet]
        public IActionResult GetProvence()
        {

            var temp = db.Provence.ToList();
            return Ok(temp);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetProvence(int id)
        {

            var temp = db.Provence.Where(_ => _.ProvenceId == id).FirstOrDefault();
            return Ok(temp);
        }

        [HttpPost]
        public IActionResult CreateProvence(Provence temp)
        {
            db.Add(temp);
            db.SaveChanges();
            return Ok(temp.ProvenceId);

        }

        [HttpPut]
        public IActionResult UpdateProvence(Provence temp)
        {

            db.Update(temp);
            db.SaveChanges();

            return NoContent();
        }


        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteProvence(int id)
        {

            var temp = db.Provence.Where(_ => _.ProvenceId == id).FirstOrDefault();
            if (temp == null)
            {
                return NotFound();
            }


            db.Provence.Remove(temp);
            db.SaveChanges();
            return NoContent();

        }

    }
}
