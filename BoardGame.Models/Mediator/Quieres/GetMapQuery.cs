using MediatR;

namespace BoardGame.Models.Mediator.Quieres;

public class GetMapQuery : IRequest<GetMapQueryResult>
{
    public string IdGame { get; set; } = "";
}
