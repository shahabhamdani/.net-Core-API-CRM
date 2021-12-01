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
    public class JobInfoController : ControllerBase
    {

        private eversrty_CRMDBContext db = new eversrty_CRMDBContext();


        [HttpGet]
        public IActionResult GetJobInfo()
        {

            var temp = db.JobInfo.ToList();
            return Ok(temp);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetJobInfo(int id)
        {

            var temp = db.JobInfo.Where(_ => _.JodInfoId == id).FirstOrDefault();
            return Ok(temp);
        }

        [HttpPost]
        public IActionResult CreateJobInfo(JobInfo temp)
        {
            db.Add(temp);
            db.SaveChanges();
            return Ok(temp.JodInfoId);

        }

        [HttpPut]
        public IActionResult UpdateJobInfo(JobInfo temp)
        {

            db.Update(temp);
            db.SaveChanges();

            return NoContent();
        }


        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteJobInfo(int id)
        {

            var temp = db.JobInfo.Where(_ => _.JodInfoId == id).FirstOrDefault();
            if (temp == null)
            {
                return NotFound();
            }


            db.JobInfo.Remove(temp);
            db.SaveChanges();
            return NoContent();

        }

    }
}
