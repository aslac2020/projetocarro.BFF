using projetocarro.BFF.DTO.UpdateCars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetocarro.BFF.Borders.UseCase
{
    public interface IUpdateCarsUseCase
    {
        UpdateCarsResponse Execute(UpdateCarsRequest request, int id);
    }
}
