//using projetocarro.BFF.Borders.Adapter;
//using projetocarro.BFF.Borders.Interfaces;
//using projetocarro.BFF.Borders.UseCase;
//using projetocarro.BFF.DTO.UpdateCars;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace projetocarro.BFF.UseCase
//{
//    public class UpdateCarsUseCase : IUpdateCarsUseCase
//    {
//        private readonly IRepositoriesCars _repositoriesCars;
//        private readonly IUpdateCarsAdapter _updateCarsAdapter;

//        public UpdateCarsUseCase(IRepositoriesCars repositoriesCars, IUpdateCarsAdapter updateCarsAdapter)
//        {
//            _repositoriesCars = repositoriesCars;
//            _updateCarsAdapter = updateCarsAdapter;
//        }
//        public UpdateCarsResponse Execute(UpdateCarsRequest request, int id)
//        {
//            var response = new UpdateCarsResponse();

//            try
//            {
//                var getById = _repositoriesCars.GetById(id);

//                if (id <= 0 || getById == null)
//                {
//                    response.msg = "Erro ao atualizar o carro";
//                    return response;
//                }

//                var updateCar = _updateCarsAdapter.converterRequestCars(request);
//                updateCar.id = id;
//                _repositoriesCars.Update(updateCar);
//                response.msg = "Carro atualizado Sucesso";
//                response.id = updateCar.id;
//                return response;

//            }
//            catch (Exception ex)
//            {
//                response.msg = "Erro ao atualizar o carro";
//                response.id = id;
//                return response;
//            }
//        }
//    }
//}
