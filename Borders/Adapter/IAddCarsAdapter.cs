using projetocarro.BFF.DTO.AddCars;
using projetocarro.BFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetocarro.BFF.Borders.Adapter
{
    public interface IAddCarsAdapter
    {
        public Cars converterRequestCars(AddCarsRequest request);
    }
}
