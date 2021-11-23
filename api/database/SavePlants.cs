using api.interfaces;

namespace api.database
{
    public class SavePlants : ISavePlant
    {
        public void CreatePlantTable()
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"CREATE TABLE posts(plantID INTERGER PRIMARY KEY AUTO_INCREMENT, plantName TEXT, seasonality TEXT, difficultyLevel INTERGER)";
        }

        public void CreatePlant(Plant myPlant)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO plants(plantID, plantName, seasonality, difficultyLevel) VALUES (@plantID, @plantName, @seasonality, @difficultyLevel)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@plantID", myPlant.plantID);
            cmd.Parameters.AddWithValue("@plantName", myPlant.plantName);
            cmd.Parameters.AddWithValue("@seasonality", myPlant.seasonality);
            cmd.Parameters.AddWithValue("@difficultyLevel", myPlant.difficultyLevel);

            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }
        public void SavePost(IGetPlant myPlant){

        }
    }
}