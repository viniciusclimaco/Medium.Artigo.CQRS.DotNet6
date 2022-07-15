using CodersInRio.Library.Models;
using MediatR;

namespace CodersInRio.Library.Queries
{
    public record GetCoffeeById(int Id) : IRequest<CoffeeModel>;
}
