using api.interfaces;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace api.database
{
    public class DeletePlants : IDeletePlants
    {
        void IDeletePlants.DeletePlant(int plantID)
        {

        }
    }
}