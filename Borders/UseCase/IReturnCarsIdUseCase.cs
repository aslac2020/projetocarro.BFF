using projetocarro.BFF.DTO.ReturnCarById;

namespace projetocarro.BFF.Borders.UseCase
{
    public interface IReturnCarsIdUseCase
    {
        ReturnCarIdResponse Execute(ReturnCarIdRequest request);
    }
}
