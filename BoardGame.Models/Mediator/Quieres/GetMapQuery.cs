using MediatR;

namespace BoardGame.Models.Mediator.Quieres;

public class GetMapQuery : IRequest<GetMapQueryResult>
{
    public int IdGame { get; set; }
}
