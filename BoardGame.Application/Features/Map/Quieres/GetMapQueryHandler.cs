using BoardGame.Models.Mediator.Quieres;
using BoardGame.Models.Repository;
using MediatR;

namespace BoardGame.Application.Features.Map.Quieres;

internal class GetMapQueryHandler(IGameStateRepository gameStateRepository) : IRequestHandler<GetMapQuery, GetMapQueryResult>
{
    public async Task<GetMapQueryResult> Handle(GetMapQuery request, CancellationToken cancellationToken)
    {
        var result = new GetMapQueryResult()
        {
            IdGame = request.IdGame,
            Map = null
        };
        if (int.TryParse(request.IdGame, out int idGame))
        {
            var state = await gameStateRepository.GetGameStateAsync(idGame);
            if (state != null)
            {
                result.Map = state.Map;
            }
        }

        return result;
    }
}
