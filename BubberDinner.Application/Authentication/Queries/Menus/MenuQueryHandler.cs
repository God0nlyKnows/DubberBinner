using BuberDinner.Application.Authentication.Queries.Menus;
using BuberDinner.Application.Common.Interfaces.Authentication;
using BuberDinner.Application.Common.Interfaces.Persistence;
using BuberDinner.Contracts;
using ErrorOr;
using MediatR;

namespace BuberDinner.Application.Authentication.Queries.Login;

public class MenuQueryHandler : IRequestHandler<MenuQuery, ErrorOr<MenuResponse>>
{
    private readonly IMenuRepository _menuRepository;

    public MenuQueryHandler(IMenuRepository menuRepository)
    {
        _menuRepository = menuRepository;
    }

    public async Task<ErrorOr<MenuResponse>> Handle(MenuQuery query, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        var menu = _menuRepository.Get(query.id);


        var avg = new AverageRating()
        {
            NumRatings = menu.AverageRating.NumRatings,
            Value = menu.AverageRating.Value
        };

        var menuResponse = new MenuResponse()
        {
            Id = menu.Id.Value,
            AverageRating = avg

        };

        return menuResponse;
    }
}