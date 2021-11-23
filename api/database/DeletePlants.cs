using api.interfaces;

namespace api.database
{
    public class DeletePlants : IDeletePlants
    {
        public static void DropPlantsTable()
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"DROP TABLE IF EXISTS plants";

            using var cmd = new mySqlCommand(stm, con);

            cmd.ExecuteNonQuery();
        }
        void IDeletePlants.DeletePlant(int plantID)
        {

        }
    }
}