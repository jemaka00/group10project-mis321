namespace api.interfaces
{
    public interface ISaveFeedback
    {
         public void CreateFeedback(Feedback myFeedback);

        public void SaveMessage(Feedback myFeedback);
    }
}