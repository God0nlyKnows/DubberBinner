using BuberDinner.Contracts;
using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Application.Authentication.Queries.Menus
{
    public record MenuQuery(Guid id) : IRequest<ErrorOr<MenuResponse>>;

}

