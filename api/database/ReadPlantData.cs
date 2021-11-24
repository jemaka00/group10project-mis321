using api.interfaces;
using System.Collections.Generic;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

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
            using var cmd = new MySqlCommand(stm, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            List<Plant> plants = new List<Plant>();

            while (rdr.Read())
            {
                Plant p = new Plant()
                {
                    plantID = rdr.GetInt32(0),
                    plantName = rdr.GetString(1),
                    plantType = rdr.GetString(2),
                    seasonality = rdr.GetString(3),
                    difficultyLevel = rdr.GetInt32(4),
                    amountOfWater = rdr.GetString(5),
                    amountOfSun = rdr.GetString(6),
                    animalAttraction = rdr.GetString(7),
                    plantImage = rdr.GetString(8)

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