using projetocarro.BFF.Borders.Interfaces;
using projetocarro.BFF.Borders.UseCase;
using projetocarro.BFF.DTO.DeleteCars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetocarro.BFF.UseCase
{
    public class DeleteCarsUseCase : IDeleteCarsUseCase
    {
        private readonly IRepositoriesCars _repositoriesCars;

        public DeleteCarsUseCase(IRepositoriesCars repositoriesCars)
        {
            _repositoriesCars = repositoriesCars;

        }


        public DeleteCarsResponse Execute(DeleteCarsRequest request)
        {
            var carsDelete = new DeleteCarsResponse();
            try
            {
                var statusId = _repositoriesCars.GetById(request.id);

                if (statusId.id == 0 || statusId == null)
                {
                    carsDelete.msg = "Id não existe";
                }

                _repositoriesCars.Remove(request.id);
                carsDelete.msg = "Carro removido com sucesso!";
                return carsDelete;
            }
            catch (Exception)
            {

                carsDelete.msg = "Erro ao deletar o carro";
                return carsDelete;
            }
          

        }
    }
}
