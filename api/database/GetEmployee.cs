using api.interfaces;
using System.Collections.Generic;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace api.database
{
    public class GetEmployee : IGetEmployee
    {
        public List<Employee> GetAllEmployees()
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = "SELECT * FROM employee";
            using var cmd = new MySqlCommand(stm, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            List<Employee> employees = new List<Employee>();

            while (rdr.Read())
            {
                Employee e = new Employee()
                {
                    employeeID = rdr.GetInt32(0),
                    empFName = rdr.GetString(1),
                    empLName = rdr.GetString(2),
                    empEmail = rdr.GetString(3),
                    empPassword = rdr.GetString(4)
                };

                employees.Add(e);
            }

            return employees;
        }
    }
}