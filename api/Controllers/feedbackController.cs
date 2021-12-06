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
    public class feedbackController : ControllerBase
    {
        // GET: api/feedback
        [EnableCors("AnotherPolicy")]
        [HttpGet]
        public List<Feedback> Get()
        {
            IGetFeedback readObject = new GetFeedback();
            return readObject.GetAllFeedback();
        }

        // POST: api/feedback
        [EnableCors("AnotherPolicy")]
        [HttpPost]
        public void Post([FromBody] Feedback value)
        {
            SaveFeedback insertObject = new SaveFeedback();
            insertObject.CreateFeedback(value);
        }

        // DELETE: api/feedback/5
        [EnableCors("AnotherPolicy")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            IDeleteFeedback deleteObject = new DeleteFeedback();
            deleteObject.DeleteMessage(id);
        }
    }
}
