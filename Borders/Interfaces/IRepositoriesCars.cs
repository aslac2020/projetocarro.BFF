using projetocarro.BFF.DTO.AddCars;

namespace projetocarro.BFF.Borders.Interfaces
{
    public interface IRepositoriesCars
    {
        public AddCarsResponse Add(AddCarsRequest cars);
        //public bool Update(Cars cars);
        public void Remove(int id);
        //public Cars GetById(int id);
        //public List<Cars> GetListCars();
    }
}
