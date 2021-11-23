namespace api.interfaces
{
    public interface ISavePlant
    {
        public void CreatePlantTable();
        public void CreatePlant(Plant myPlant);

        public void SavePlant(IGetPlant myPlant);
    }
}