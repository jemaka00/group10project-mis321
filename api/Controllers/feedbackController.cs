using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using api.interfaces;
using api.database;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class feedbackController : ControllerBase
    {
        // GET: api/feedback
        [HttpGet]
        public List<Feedback> Get()
        {
            IGetFeedback readObject = new GetFeedback();
            return readObject.GetAllFeedback();
        }

        // POST: api/feedback
        [HttpPost]
        public void Post([FromBody] Feedback value)
        {
            ISaveFeedback insertObject = new SaveFeedback();
            insertObject.CreateFeedback(value);
        }

        // DELETE: api/feedback/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            IDeleteFeedback deleteObject = new DeleteFeedback();
            deleteObject.DeleteMessage(id);
        }
    }
}
