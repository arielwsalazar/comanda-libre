using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandaLibre.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CommandaLibre.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        List<CLEmployee> cLEmployees = new List<CLEmployee>()
        {
            new CLEmployee(){ Name = "pepe",Lastname="sanchez"},
            new CLEmployee(){ Name = "maria",Lastname="la del mar"},
            new CLEmployee(){ Name = "mariquita",Lastname="sanchez"},
            new CLEmployee(){ Name = "jose",Lastname="mujica"}
        };

        [HttpGet]
        public IEnumerable<CLEmployee> Get()
        {
            return cLEmployees;
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
