using projetocarro.BFF.Borders.Adapter;
using projetocarro.BFF.DTO.UpdateCars;
using projetocarro.BFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetocarro.BFF.Adapter
{
    public class UpdateCarsAdapter : IUpdateCarsAdapter
    {
        public Cars converterRequestCars(UpdateCarsRequest request)
        {
            var newCars = new Cars();
            newCars.Model = request.Model;
            newCars.Cor = request.Cor;
            newCars.Year = request.Year;
            newCars.Brands = request.Brands;
            newCars.NumberDoors = request.NumberDoors;
            newCars.TypeRate = request.TypeRate;

            return newCars;
        }
    }
}
