using projetocarro.BFF.Borders.Adapter;
using projetocarro.BFF.Borders.Interfaces;
using projetocarro.BFF.Borders.UseCase;
using projetocarro.BFF.DTO.AddCars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetocarro.BFF.UseCase
{
    public class AddCarsUseCase  : IAddCarsUseCase
    {
        private readonly IRepositoriesCars _repositoriesCars;
        private readonly IAddCarsAdapter _addCarsAdapter;

        public AddCarsUseCase(IRepositoriesCars repositoriesCars, IAddCarsAdapter addCarsAdapter)
        {
            _repositoriesCars = repositoriesCars;
            _addCarsAdapter = addCarsAdapter;

        }

        public AddCarsResponse Execute(AddCarsRequest cars)
        {
            var result = _repositoriesCars.Add(cars);
            return result;
        }

        //public AddCarsResponse Execute(AddCarsRequest request)
        //{
        //    var response = new AddCarsResponse();

        //    try
        //    {
        //        if (request.Model.Length < 3)
        //        {
        //            response.msg = "Erro ao adicionar o carro";
        //            return response;
        //        }

        //        var addCar = _addCarsAdapter.converterRequestCars(request);
        //        _repositoriesCars.Add(addCar);
        //        response.msg = "Adicionado com Sucesso";
        //        response.id = addCar.id;
        //        return response;

        //    }
        //    catch (Exception)
        //    {

        //        response.msg = "Erro ao adicionar o carro";
        //        return response;
        //    }
    }
    
}
