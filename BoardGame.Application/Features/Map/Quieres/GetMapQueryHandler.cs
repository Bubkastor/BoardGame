using BoardGame.Models.Mediator.Quieres;
using BoardGame.Repository;
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
        var state = await gameStateRepository.GetGameStateAsync(request.IdGame);
        if (state != null)
        {
            result.Map = state.Map;
        }

        return result;
    }
}
