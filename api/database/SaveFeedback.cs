using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using api.interfaces;

namespace api.database
{
    public class SaveFeedback : ISaveFeedback
    {
        public void CreateFeedback(Feedback myFeedback)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO feedback(customerID, customerName, customerEmail, phoneNumber, feedback) 
            VALUES (@customerID, @customerName, @customerEmail, @phoneNumber, @feedback)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@customerID", myFeedback.customerID);
            cmd.Parameters.AddWithValue("@customerName", myFeedback.customerName);
            cmd.Parameters.AddWithValue("@customerEmail", myFeedback.customerEmail);
            cmd.Parameters.AddWithValue("@phoneNumber", myFeedback.phoneNumber);
            cmd.Parameters.AddWithValue("@feedback", myFeedback.feedback);
        
            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }
        public void SaveMessage(Feedback myFeedback){
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();
            string stm = @"UPDATE feedback set customerName = @customerName, customerEmail = @customerEmail, 
            phoneNumber = @phoneNumber, feedback = @feedback WHERE customerID = @customerID";
            using var cmd = new MySqlCommand(stm, con);
            
            cmd.Parameters.AddWithValue("@customerName", myFeedback.customerName);
            cmd.Parameters.AddWithValue("@customerEmail", myFeedback.customerEmail);
            cmd.Parameters.AddWithValue("@phoneNumber", myFeedback.phoneNumber);
            cmd.Parameters.AddWithValue("@feedback", myFeedback.feedback);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
    }
}
}