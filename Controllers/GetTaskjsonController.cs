using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWebApi.Data;
namespace ProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetTaskjsonController : ControllerBase
    {
        ProjectDBContext _context;
        public GetTaskjsonController(ProjectDBContext context)
        {
            _context = context;
        }

        // GET: api/GetTaskjson
        [HttpGet]
        public IActionResult GetTask()
        {
            return Ok(_context.Tasks.ToList());
        }

        // GET: api/GetTaskjson/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/GetTaskjson
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/GetTaskjson/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
