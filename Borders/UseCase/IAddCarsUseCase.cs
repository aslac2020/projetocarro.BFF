using projetocarro.BFF.DTO.AddCars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetocarro.BFF.Borders.UseCase
{
    public interface IAddCarsUseCase
    {
        AddCarsResponse Execute(AddCarsRequest request);
    }
}
