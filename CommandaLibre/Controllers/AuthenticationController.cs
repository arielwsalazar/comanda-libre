using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CommandaLibre.Models;
using Microsoft.AspNetCore.Http;
using System.Net;

namespace CommandaLibre.Controllers
{
    [Route("api/[controller]")]
    public class AuthenticationController : Controller
    {
        //mock
        List<CLUsers> clusers = new List<CLUsers>()
                {
                    new CLUsers(){ User="admin",Password="admin"},
                    new CLUsers(){ User="mozo",Password="mozo"},
                    new CLUsers(){ User="cocinero",Password="cocinero"}
                };

        [HttpGet]
        public List<CLUsers> Get()
        {
            return clusers;
        }

        [HttpGet("{user}")]
        public CLUsers Get(string user)
        {
            CLUsers cluser = clusers.FirstOrDefault(u => u.User == user);

            if (cluser != null)
            {
                return cluser;
            }

            //HttpStatusCode.MethodNotAllowed
            return new CLUsers();
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
