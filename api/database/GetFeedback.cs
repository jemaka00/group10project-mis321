using api.interfaces;
using System.Collections.Generic;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace api.database
{
    public class GetFeedback : IGetFeedback
    {
        public List<Feedback> GetAllFeedback()
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = "SELECT * FROM feedback";
            using var cmd = new MySqlCommand(stm, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            List<Feedback> feedback = new List<Feedback>();

            while (rdr.Read())
            {
                Feedback f = new Feedback()
                {
                    customerID = rdr.GetInt32(0),
                    customerName = rdr.GetString(1),
                    customerEmail = rdr.GetString(2),
                    phoneNumber = rdr.GetString(3),
                    feedback = rdr.GetString(4)
                };

                feedback.Add(f);
            }

            return feedback;
        }
    }
}