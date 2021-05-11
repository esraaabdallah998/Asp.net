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
    public class GetEventjsonController : ControllerBase
    {
        ProjectDBContext _context;
        public GetEventjsonController(ProjectDBContext context)
        {
            _context = context;
        }
        // GET: api/GetEventjson
        [HttpGet]
        public IActionResult GetEvent()
        {
            return Ok(_context.Events.ToList());
        }

        // GET: api/GetEventjson/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/GetEventjson
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/GetEventjson/5
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
