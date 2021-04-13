using projetocarro.BFF.DTO.UpdateCars;
using projetocarro.BFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetocarro.BFF.Borders.Adapter
{
    public interface IUpdateCarsAdapter
    {
        public Cars converterRequestCars(UpdateCarsRequest request);
    }
}
