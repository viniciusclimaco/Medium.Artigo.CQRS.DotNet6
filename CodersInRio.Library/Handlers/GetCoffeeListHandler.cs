using CodersInRio.Library.Models;
using CodersInRio.Library.Queries;
using CodersInRio.Library.Repositories;
using MediatR;

namespace CodersInRio.Library.Handlers
{
    public class GetCoffeeListHandler : IRequestHandler<GetCoffeeList, List<CoffeeModel>>
    {
        private readonly ICoffeeRepository _coffeeRepository;
        public GetCoffeeListHandler(ICoffeeRepository coffeeRepository)
        {
            _coffeeRepository = coffeeRepository;
        }

        public Task<List<CoffeeModel>> Handle(GetCoffeeList request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_coffeeRepository.GetAll());
        }
    }
}
