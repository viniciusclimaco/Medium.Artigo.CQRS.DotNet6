using CodersInRio.Library.Models;
using MediatR;

namespace CodersInRio.Library.Queries
{
    public record GetCoffeeList():IRequest<List<CoffeeModel>>;
}
