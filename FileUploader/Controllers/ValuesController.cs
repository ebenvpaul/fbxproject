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
public async Task<IActionResult> Download()
{
    var path = "SavedFiles/house.FBX";
    FileStream uploadFileStream = System.IO.File.OpenRead(path);
    // return new FileStreamResult(uploadFileStream, "application/octet-stream");
    return File(uploadFileStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");

}

        // GET api/values/5
        [HttpGet("{id}")]
       public async Task<IActionResult> Download(int id)
{
    var path = "SavedFiles/house.FBX";
    if (id==1){
         path = "SavedFiles/fbx1.fbx";
    }
    if(id==2){
          path = "SavedFiles/fbx2.fbx";
    }
    if(id==3){
          path = "SavedFiles/fbx3.fbx";
    }
    else{
        
          path = "SavedFiles/house.FBX";
    }
    FileStream uploadFileStream = System.IO.File.OpenRead(path);
    // return new FileStreamResult(uploadFileStream, "application/octet-stream");
    return File(uploadFileStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");

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
