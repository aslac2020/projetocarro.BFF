using projetocarro.BFF.Borders.Interfaces;
using projetocarro.BFF.Borders.UseCase;
using projetocarro.BFF.DTO.ReturnCarById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetocarro.BFF.UseCase
{
    public class ReturnCarsIdUseCase : IReturnCarsIdUseCase
    {
        private readonly IRepositoriesCars _repositoriesCars;

        public ReturnCarsIdUseCase(IRepositoriesCars repositoriesCars)
        {
            _repositoriesCars = repositoriesCars;
        }
        public ReturnCarIdResponse Execute(ReturnCarIdRequest request)
        {
            var response = new ReturnCarIdResponse();

            try
            {
                var getById = _repositoriesCars.GetById(request.id);

                if (request.id <= 0 || getById == null)
                {
                    response.msg = "Id não encontrado :(";
                    return response;
                }

                response = getById;
                response.msg = "Carro encontrado com Sucesso";
                return response;

            }
            catch (Exception)
            {

                response.msg = "Falha ao procurar o carro :(";
                return response;
            }
        }
    }
}
