using CodersInRio.Library.Models;
using MediatR;

namespace CodersInRio.Library.Commands
{
    public record  AddCoffee(string Name, string Size): IRequest<CoffeeModel>;
    
}
