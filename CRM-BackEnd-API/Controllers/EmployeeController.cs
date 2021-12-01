


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
    public class EmployeeController : ControllerBase
    {

        private eversrty_CRMDBContext db = new eversrty_CRMDBContext();


        [HttpGet]
        public IActionResult GetEmployee()
        {

            var temp = db.Employee.ToList();
            return Ok(temp);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetEmployee(int id)
        {

            var temp = db.Employee.Where(_ => _.EmployeeId == id).FirstOrDefault();
            return Ok(temp);
        }

        [HttpPost]
        public IActionResult CreateEmployee(Employee temp)
        {
            db.Add(temp);
            db.SaveChanges();
            return Ok(temp.EmployeeId);

        }

        [HttpPut]
        public IActionResult UpdateEmployee( Employee temp)
        {
           
            db.Employee.Update(temp);
            db.SaveChanges();

            return NoContent();
        }


        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteEmployee(int id)
        {

            var temp = db.Employee.Where(_ => _.EmployeeId == id).FirstOrDefault();
            if (temp == null)
            {
                return NotFound();
            }


            db.Remove(temp);
            db.SaveChanges();
            return NoContent();

        }

    }
}
