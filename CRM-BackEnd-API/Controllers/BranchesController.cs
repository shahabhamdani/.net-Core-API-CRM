


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
    public class BranchesController : ControllerBase
    {

        private eversrty_CRMDBContext db = new eversrty_CRMDBContext();


        [HttpGet]
        public IActionResult GetBranches()
        {

            var branches = db.Branches.ToList();
            return Ok(branches);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetBranches(int id)
        {

            var branch = db.Branches.Where(_ => _.BranchId == id).FirstOrDefault();
            return Ok(branch);
        }

        [HttpPost]
        public IActionResult CreateBranch(Branches branch)
        {
            db.Add(branch);
            db.SaveChanges();
            return Ok(branch.BranchId);

        }

        [HttpPut]
        public IActionResult UpdateBranch( Branches branch)
        {
           
            db.Update(branch);
            db.SaveChanges();

            return NoContent();
        }


        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteBranch(int id)
        {

            var branchToDelete = db.Branches.Where(_ => _.BranchId == id).FirstOrDefault();
            if (branchToDelete == null)
            {
                return NotFound();
            }


            db.Branches.Remove(branchToDelete);
            db.SaveChanges();
            return NoContent();

        }

    }
}
