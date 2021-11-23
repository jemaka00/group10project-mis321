using api.interfaces;
using System.Collections.Generic;

namespace api.database
{
    public class ReadPlantData : IGetAllPlants, IGetPlant
    {
        public List<Plant> GetAllPlants()
        {

        }

        public Plant GetPlant(int plantID)
        {
            
        }
    }
}