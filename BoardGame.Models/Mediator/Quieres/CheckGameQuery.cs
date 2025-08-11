using MediatR;

namespace BoardGame.Models.Mediator.Quieres;

public class CheckGameQuery:  IRequest<CheckGameQueryResult>
{
    public string IdGame { get; set; } = "0";
}