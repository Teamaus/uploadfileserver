using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UploadFileAPI.Model;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UploadFileAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadFileController : ControllerBase
    {
        // GET: api/<UploadFileController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UploadFileController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UploadFileController>
        [HttpPost]
        public void Post(FileModel fileModel)
        {
            byte[] bytes = Convert.FromBase64String(fileModel.File.Split(',')[1]);

            using (BinaryWriter writer = new BinaryWriter(System.IO.File.Open(@"C:\DOD\Dev++\fullstack_course_2021_4\repos\fsfinalclient_training\FileUpload\src\assets\test.png", FileMode.Create))) 
            {
                writer.Write(bytes);

            }



        }

   

        // PUT api/<UploadFileController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UploadFileController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
