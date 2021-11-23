using api.interfaces;
using System.Collections.Generic;

namespace api.database
{
    public class ReadPlantData : IGetAllPlants, IGetPlant
    {
        public List<Plant> GetAllPlants()
        {
            //have to add this to deploy on heroku
        }

        public Plant GetPlant(int plantID)
        {
            //have to add this to deploy on heroku
        }
    }
}