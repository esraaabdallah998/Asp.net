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
    public class GetNotejsonController : ControllerBase
    {
        ProjectDBContext _context;

        public GetNotejsonController(ProjectDBContext context)
        {
            _context = context;
        }

        // GET: api/GetNotejson
        [HttpGet]
        public IActionResult GetNote()
        {
            return Ok(_context.Notes.ToList());
        }

        // GET: api/GetNotejson/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/GetNotejson
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/GetNotejson/5
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
