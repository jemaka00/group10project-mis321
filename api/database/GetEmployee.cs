using api.interfaces;

namespace api.database
{
    public class GetEmployeem: IGetEmployee
    {
        public Employee GetEmployee(int employeeID)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = "SELECT * FROM employee WHERE employeeID = @empID";
            var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@plantID", employeeID);
            cmd.Prepare();

            MySqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();

            Employee e = new Employee()
            {
                employeeID = rdr.GetInt32(0),
                empFName = rdr.GetString(1),
                empLName = rdr.GetString(2),
                empEmail = rdr.GetString(3),
                empPassword = rdr.GetString(4)
            };

            return p;
        }
    }
}