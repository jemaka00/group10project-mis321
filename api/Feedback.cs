using api.interfaces;
using api.database;

namespace api
{
    public class Feedback
    {
        public int customerID {get; set;}

        public string customerName {get; set;}
        public string customerEmail {get; set;}

        public string phoneNumber {get; set;}

        public string feedback {get; set;}


        public ISaveFeedback Save {get; set;}

        public Feedback()
        {
            Save = new SaveFeedback();
        }
    }
}