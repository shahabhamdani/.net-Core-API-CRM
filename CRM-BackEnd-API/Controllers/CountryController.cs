


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
    public class CountryController : ControllerBase
    {

        private eversrty_CRMDBContext db = new eversrty_CRMDBContext();


        [HttpGet]
        public IActionResult GetCountry()
        {

            var temp = db.Country.ToList();
            return Ok(temp);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetCountry(int id)
        {

            var temp = db.Country.Where(_ => _.CountryId == id).FirstOrDefault();
            return Ok(temp);
        }

        [HttpPost]
        public IActionResult CreateCountry(Country temp)
        {
            db.Add(temp);
            db.SaveChanges();
            return Ok(temp.CountryId);

        }

        [HttpPut]
        public IActionResult UpdateCountry(Country temp)
        {

            db.Update(temp);
            db.SaveChanges();

            return NoContent();
        }


        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteCountry(int id)
        {

            var temp = db.Country.Where(_ => _.CountryId == id).FirstOrDefault();
            if (temp == null)
            {
                return NotFound();
            }


            db.Country.Remove(temp);
            db.SaveChanges();
            return NoContent();

        }

    }
}
