using api.Interaces;
using api.database;

namespace api
{
    public class Plant
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