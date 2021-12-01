


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
    public class DepartmentController : ControllerBase
    {

        private eversrty_CRMDBContext db = new eversrty_CRMDBContext();


        [HttpGet]
        public IActionResult GetDepartment()
        {

            var temp = db.Department.ToList();
            return Ok(temp);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetDepartment(int id)
        {

            var temp = db.Department.Where(_ => _.DepartmentId == id).FirstOrDefault();
            return Ok(temp);
        }

        [HttpPost]
        public IActionResult CreateDepartment(Department temp)
        {
            db.Add(temp);
            db.SaveChanges();
            return Ok(temp.DepartmentId);

        }

        [HttpPut]
        public IActionResult UpdateDepartment( Department temp)
        {
           
            db.Update(temp);
            db.SaveChanges();

            return NoContent();
        }


        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteDepartment(int id)
        {

            var dpt = db.Department.Where(_ => _.DepartmentId == id).FirstOrDefault();
            if (dpt == null)
            {
                return NotFound();
            }


            db.Department.Remove(dpt);
            db.SaveChanges();
            return NoContent();

        }

    }
}
