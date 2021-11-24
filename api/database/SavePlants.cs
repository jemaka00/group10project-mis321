using api.interfaces;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace api.database
{
    public class SavePlants : ISavePlant
    {

        public void CreatePlant(Plant myPlant)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO plants(plantID, plantName, plantType, seasonality, difficultyLevel, amountOfWater, amountOfSun, animalAttraction, plantImage) 
            VALUES (@plantID, @plantName, @plantType, @seasonality, @difficultyLevel, @amountOfWater, @amountOfSun, @animalAttraction, @plantImage)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@plantID", myPlant.plantID);
            cmd.Parameters.AddWithValue("@plantName", myPlant.plantName);
            cmd.Parameters.AddWithValue("@plantType", myPlant.plantType);
            cmd.Parameters.AddWithValue("@seasonality", myPlant.seasonality);
            cmd.Parameters.AddWithValue("@difficultyLevel", myPlant.difficultyLevel);
            cmd.Parameters.AddWithValue("@amountOfWater", myPlant.amountOfWater);
            cmd.Parameters.AddWithValue("@amountOfSun", myPlant.amountOfSun);
            cmd.Parameters.AddWithValue("@animalAttraction", myPlant.animalAttraction);
            cmd.Parameters.AddWithValue("@plantImage", myPlant.plantImage);

            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }
        public void SavePlant(IGetPlant myPlant){

        }
    }
}