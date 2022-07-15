using CodersInRio.Library.Models;
using CodersInRio.Library.Queries;
using MediatR;

namespace CodersInRio.Library.Handlers
{
    public class GetCoffeeByIdHandler : IRequestHandler<GetCoffeeById, CoffeeModel>
    {
        private readonly IMediator _mediator;
        public GetCoffeeByIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }


        public async Task<CoffeeModel> Handle(GetCoffeeById request, CancellationToken cancellationToken)
        {
            var employees = await _mediator.Send(new GetCoffeeList());
            var searched = employees.FirstOrDefault(x => x.Id == request.Id);
            return searched;
        }
    }
}
