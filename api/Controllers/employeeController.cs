using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using api.database;
using api.interfaces;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class employeeController : ControllerBase
    {
        // GET: api/plants
        [EnableCors("AnotherPolicy")]
        [HttpGet]
        public List<Employee> Get()
        {
            IGetEmployee readObject = new GetEmployee();
            return readObject.GetAllEmployees();
        }
    }
}
