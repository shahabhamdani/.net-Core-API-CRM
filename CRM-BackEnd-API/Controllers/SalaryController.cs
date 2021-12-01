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
    public class SalaryController : ControllerBase
    {

        private eversrty_CRMDBContext db = new eversrty_CRMDBContext();


        [HttpGet]
        public IActionResult GetSalary()
        {

            var temp = db.Salary.ToList();
            return Ok(temp);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetSalary(int id)
        {

            var temp = db.Salary.Where(_ => _.SalaryId == id).FirstOrDefault();
            return Ok(temp);
        }

        [HttpPost]
        public IActionResult CreateSalary(Salary temp)
        {
            db.Add(temp);
            db.SaveChanges();
            return Ok(temp.SalaryId);

        }

        [HttpPut]
        public IActionResult UpdateSalary(Salary temp)
        {

            db.Update(temp);
            db.SaveChanges();

            return NoContent();
        }


        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteSalary(int id)
        {

            var temp = db.Salary.Where(_ => _.SalaryId == id).FirstOrDefault();
            if (temp == null)
            {
                return NotFound();
            }


            db.Salary.Remove(temp);
            db.SaveChanges();
            return NoContent();

        }

    }
}
