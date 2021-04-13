using projetocarro.BFF.DTO.ReturnListCars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetocarro.BFF.Borders.UseCase
{
    public interface IReturnListCarsUseCase
    {
        ReturnListCarsResponse Execute();
    }
}
