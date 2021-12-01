


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
    public class DesignationController : ControllerBase
    {

        private eversrty_CRMDBContext db = new eversrty_CRMDBContext();


        [HttpGet]
        public IActionResult GetDesignation()
        {

            var temp = db.Designation.ToList();
            return Ok(temp);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetDesignation(int id)
        {

            var temp = db.Designation.Where(_ => _.DesignationId == id).FirstOrDefault();
            return Ok(temp);
        }

        [HttpPost]
        public IActionResult CreatDesignation(Designation temp)
        {
            db.Add(temp);
            db.SaveChanges();
            return Ok(temp.DesignationId);

        }

        [HttpPut]
        public IActionResult UpdateDesignation(Designation temp)
        {

            db.Update(temp);
            db.SaveChanges();

            return NoContent();
        }


        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteDesignation(int id)
        {

            var temp = db.Designation.Where(_ => _.DesignationId == id).FirstOrDefault();
            if (temp == null)
            {
                return NotFound();
            }


            db.Designation.Remove(temp);
            db.SaveChanges();
            return NoContent();

        }

    }
}
