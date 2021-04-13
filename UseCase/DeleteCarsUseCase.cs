//using projetocarro.BFF.Borders.Interfaces;
//using projetocarro.BFF.Borders.UseCase;
//using projetocarro.BFF.DTO.DeleteCars;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace projetocarro.BFF.UseCase
//{
//    public class DeleteCarsUseCase : IDeleteCarsUseCase
//    {
//        private readonly IRepositoriesCars _repositoriesCars;

//        public DeleteCarsUseCase(IRepositoriesCars repositoriesCars)
//        {
//            _repositoriesCars = repositoriesCars;

//        }

//        public DeleteCarsResponse Execute(DeleteCarsRequest request)
//        {
//            var response = new DeleteCarsResponse();

//            try
//            {
//                var getById = _repositoriesCars.GetById(request.id);

//                if (request.id <= 0 || getById == null)
//                {
//                    response.msg = "Não encontrado o id :( ";
//                    return response;
//                }

//                _repositoriesCars.Remove(request.id);
//                response.msg = "Deletado com Sucesso";
//                return response;

//            }
//            catch (Exception)
//            {

//                response.msg = "Falha ao deletar o carro :(";
//                return response;
//            }
//        }
//    }
//}
