namespace api.interfaces
{
    public interface ISavePlants
    {
        public static void CreatePlantTable();
        public void CreatePlant(Plant myPlant);

        public void SavePost(IGetPlant myPlant);
    }
}