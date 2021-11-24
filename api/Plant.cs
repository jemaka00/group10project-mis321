using api.interfaces;
using api.database;

namespace api
{
    public class Plant
    {
        public int plantID {get; set;}

        public string plantName {get; set;}
        public string plantType {get; set;}

        public string seasonality {get; set;}

        public int difficultyLevel {get; set;}
        public string amountOfWater {get; set;}
        public string amountOfSun {get; set;}
        public string animalAttraction {get; set;}
        public string plantImage {get; set;}


        public ISavePlant Save {get; set;}

        public Plant()
        {
            Save = new SavePlants();
        }
    }
}