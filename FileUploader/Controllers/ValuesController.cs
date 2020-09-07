using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Web.Http.Cors;

namespace FileUploader.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
public async Task<FileStreamResult>Download()
{
    var path = "SavedFiles/house.FBX";
    FileStream uploadFileStream = System.IO.File.OpenRead(path) ;
    return new FileStreamResult(uploadFileStream, "application/octet-stream");
}

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }


        

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
