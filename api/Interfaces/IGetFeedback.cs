using System.Collections.Generic;

namespace api.interfaces
{
    public interface IGetFeedback
    {
        public List<Feedback> GetAllFeedback();
    }
}