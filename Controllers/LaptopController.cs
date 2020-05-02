using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Laptop.Models;
namespace Laptop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaptopController : ControllerBase
    {
        // GET: api/Laptop


       
        [HttpGet]
        public laptop Get()
        {
            Models.laptop l = new Models.laptop()
            {
                Id = 1,
                Name = "dell"
            };

            return l;

        }
    }
}
