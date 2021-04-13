using projetocarro.BFF.DTO.AddCars;
using projetocarro.BFF.DTO.DeleteCars;
using projetocarro.BFF.DTO.ReturnCarById;
using projetocarro.BFF.DTO.ReturnListCars;
using projetocarro.BFF.DTO.UpdateCars;
using projetocarro.BFF.Models;
using System.Collections.Generic;

namespace projetocarro.BFF.Borders.Interfaces
{
    public interface IRepositoriesCars
    {
        public AddCarsResponse Add(AddCarsRequest cars);
        public int Update(Cars cars, int id);
        public void Remove(int id);
        public ReturnCarIdResponse GetById(int id);
        public ReturnListCarsResponse GetListCars();
    }
}
