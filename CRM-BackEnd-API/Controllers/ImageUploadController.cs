


using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRM_BackEnd_API.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace CRM_BackEnd_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImageUploadController : ControllerBase
    {

        private eversrty_CRMDBContext db = new eversrty_CRMDBContext();

        public static IWebHostEnvironment _environment;
        public ImageUploadController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public class FileUpload
        {
            public IFormFile files
            {
                get;
                set;
            }
        }

        [HttpPost]
        public async Task<string> Post([FromForm] FileUpload objfile, IFormCollection data)
        {

            data.TryGetValue("id", out var cnic);


            if (objfile.files.Length > 0)
            {
                try
                {
                    if(!Directory.Exists(_environment.WebRootPath + "\\uploads\\"))
                    {
                        Directory.CreateDirectory(_environment.WebRootPath + "\\uploads\\");
                    }
                    using (FileStream filestream = System.IO.File.Create(_environment.WebRootPath + "\\uploads\\" +cnic+objfile.files.FileName))
                    {
                        objfile.files.CopyTo(filestream);
                        filestream.Flush();


                        return "\\uploads\\" + objfile.files.FileName;
                    }
                }
                catch(Exception e)
                {
                    return e.ToString();
                }
            }
            else
            {
                return "Unsuccessful";
            }



        }


        [HttpGet("{img}")]
        public IActionResult Get(string img)
        {
            var path = Path.Combine(_environment.WebRootPath, "uploads",img);
            var imageFileStream = System.IO.File.OpenRead(path);
            return File(imageFileStream, "image/jpeg");
        }


    }
}
