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
    public class GetContactjsonController : ControllerBase
    {
        ProjectDBContext _context;
        public GetContactjsonController(ProjectDBContext context) 
        {
            _context = context;
        }

        // GET: api/GetContactjson
        [HttpGet]
        public IActionResult GetContact()
        {
            return Ok(_context.Contacts.ToList());
        }

        // GET: api/GetContactjson/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/GetContactjson
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/GetContactjson/5
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
