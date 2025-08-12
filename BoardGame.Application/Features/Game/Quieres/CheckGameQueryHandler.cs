using BoardGame.Models.Mediator.Quieres;
using BoardGame.Models.Repository;
using MediatR;

namespace BoardGame.Application.Features.Game.Quieres;

public class CheckGameQueryHandler(IGameStateRepository gameStateRepository): IRequestHandler<CheckGameQuery, CheckGameQueryResult>
{
    public async Task<CheckGameQueryResult> Handle(CheckGameQuery request, CancellationToken cancellationToken)
    {
        if (int.TryParse(request.IdGame, out int idGame))
        {
            var result = await gameStateRepository.GetGameStateAsync(idGame);
            return new CheckGameQueryResult()
            {
                GameExist = result != null
            };
        }
        else
        {
            return new CheckGameQueryResult()
            {
                GameExist = false
            };
        }
    }
}