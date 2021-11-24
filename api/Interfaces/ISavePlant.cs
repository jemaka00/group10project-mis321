namespace api.interfaces
{
    public interface ISavePlant
    {
        public void CreatePlant(Plant myPlant);

        public void SavePlant(IGetPlant myPlant);
    }
}