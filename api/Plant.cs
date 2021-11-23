using api.interfaces;
using api.database;

namespace api
{
    public class Plant : ISavePlant
    {
        public int plantID {get; set;}

        public string plantName {get; set;}

        public string seasonality {get; set;}

        public int difficultyLevel {get; set;}

        public ISavePlant Save {get; set;}

        public Plant()
        {
            Save = new SavePlants();
        }
    }
}