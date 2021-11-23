using api.interfaces;
using System.Collections.Generic;

namespace api.database
{
    public class ReadPlantData : IGetAllPlants, IGetPlant
    {
        public List<Plant> GetAllPlants()
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = "SELECT * FROM plants";
            var cmd = new MySqlCommand(stm, con);

            MySqlDataReader rdr = cmd.ExecuteReader();

            List<Plant> plants = new List<Plant>();

            while (rdr.Read())
            {
                Plant p = new Plant()
                {
                    plantID = rdr.GetInt32(0),
                    plantName = rdr.GetString(1),
                    seasonality = rdr.GetString(2),
                    difficultyLevel = rdr.GetInt32(3)

                };

                plants.Add(p);
            }

            return plants;
        }

        public Plant GetPlant(int plantID)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = "SELECT * FROM plants WHERE plantID = @plantID";
            var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@plantID", plantID);
            cmd.Prepare();

            MySqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();

            Plant p = new Plant()
            {
                plantID = rdr.GetInt32(0),
                plantName = rdr.GetString(1),
                seasonality = rdr.GetString(2),
                difficultyLevel = rdr.GetInt32(3)
            };

            return p;
        }
    }
}