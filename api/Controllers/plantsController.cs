using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using api.database;
using api.interfaces;
using api;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class plantsController : ControllerBase
    {
        // GET: api/plants
        [EnableCors("AnotherPolicy")]
        [HttpGet]
        public List<Plant> Get()
        {
            IGetAllPlants readObject = new ReadPlantData();
            return readObject.GetAllPlants();
        }

        // GET: api/plants/5
        [EnableCors("AnotherPolicy")]
        [HttpGet("{id}", Name = "Get")]
        public Plant Get(int id)
        {
            IGetPlant readObject = new ReadPlantData();
            return readObject.GetPlant(id);
        }

        // POST: api/plants
        [EnableCors("AnotherPolicy")]
        [HttpPost]
        public void Post([FromBody] Plant value)
        {
            ISavePlant insertObject = new SavePlants();
            insertObject.CreatePlant(value);
        }

        // PUT: api/plants/5
        [EnableCors("AnotherPolicy")]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Plant value)
        {
            ISavePlant editObject = new SavePlants();
            editObject.SavePlant(value);
        }

        // DELETE: api/plants/5
        [EnableCors("AnotherPolicy")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            IDeletePlants deleteObject = new DeletePlants();
            deleteObject.DeletePlant(id);
        }
    }
}
