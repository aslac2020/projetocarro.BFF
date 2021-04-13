using projetocarro.BFF.DTO.DeleteCars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetocarro.BFF.Borders.UseCase
{
    public interface IDeleteCarsUseCase
    {
        DeleteCarsResponse Execute(DeleteCarsRequest request);
    }
}
