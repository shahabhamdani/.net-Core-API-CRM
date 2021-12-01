


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
    public class CityController : ControllerBase
    {

        private eversrty_CRMDBContext db = new eversrty_CRMDBContext();


        [HttpGet]
        public IActionResult GetCity()
        {

            var city = db.City.ToList();
            return Ok(city);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetCity(int id)
        {

            var city = db.City.Where(_ => _.CityId == id).FirstOrDefault();
            return Ok(city);
        }

        [HttpPost]
        public IActionResult CreateCity(City city)
        {
            db.Add(city);
            db.SaveChanges();
            return Ok(city.CityId);

        }

        [HttpPut]
        public IActionResult UpdateCity(City city)
        {

            db.Update(city);
            db.SaveChanges();

            return NoContent();
        }


        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteCity(int id)
        {

            var cityToDelete = db.City.Where(_ => _.CityId == id).FirstOrDefault();
            if (cityToDelete == null)
            {
                return NotFound();
            }


            db.City.Remove(cityToDelete);
            db.SaveChanges();
            return NoContent();

        }

    }
}
