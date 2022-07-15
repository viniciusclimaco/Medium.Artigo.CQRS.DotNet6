using CodersInRio.Library.Commands;
using CodersInRio.Library.Models;
using CodersInRio.Library.Repositories;
using MediatR;

namespace CodersInRio.Library.Handlers
{
    public class AddCoffeeHandler : IRequestHandler<AddCoffee, CoffeeModel>
    {
        private readonly ICoffeeRepository _coffeeRepository;
        public AddCoffeeHandler(ICoffeeRepository coffeeRepository)
        {
            _coffeeRepository = coffeeRepository;
        }
        public Task<CoffeeModel> Handle(AddCoffee request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_coffeeRepository.Add(request.Name, request.Size));
        }
    }
}
