


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
    public class CompanyController : ControllerBase
    {

        private eversrty_CRMDBContext db = new eversrty_CRMDBContext();


        [HttpGet]
        public IActionResult GetCompanies()
        {

            var companies = db.Company.ToList();
            return Ok(companies);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetCompany(int id)
        {

            var company = db.Company.Where(_ => _.CompanyId == id).FirstOrDefault();
            return Ok(company);
        }

        [HttpPost]
        public IActionResult CreateCompany(Company company)
        {
            db.Add(company);
            db.SaveChanges();
            return Ok(company.CompanyId);

        }

        [HttpPut]
        public IActionResult UpdateCompany( Company company)
        {
           
            db.Update(company);
            db.SaveChanges();

            return NoContent();
        }


        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteCompany(int id)
        {

            var companyToDelete = db.Company.Where(_ => _.CompanyId == id).FirstOrDefault();
            if (companyToDelete == null)
            {
                return NotFound();
            }


            db.Company.Remove(companyToDelete);
            db.SaveChanges();
            return NoContent();

        }






    }
}
