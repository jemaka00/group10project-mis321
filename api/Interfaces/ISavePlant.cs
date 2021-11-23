namespace api.interfaces
{
    public interface ISavePlants
    {
        public void CreatePlantTable();
        public void CreatePlant(Plant myPlant);

        public void SavePlant(IGetPlant myPlant);
    }
}