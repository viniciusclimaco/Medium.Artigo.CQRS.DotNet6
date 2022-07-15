using CodersInRio.Library.Commands;
using CodersInRio.Library.Models;
using CodersInRio.Library.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CodersInRio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CoffeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<CoffeeModel>> Get()
        {
            return await _mediator.Send(new GetCoffeeList());
        }

        [HttpGet("{id}")]
        public async Task<CoffeeModel> Get(int id)
        {
            return await _mediator.Send(new GetCoffeeById(id));
        }

        [HttpPost]
        public async Task<CoffeeModel> Post([FromBody]CoffeeModel model)
        {
            return await _mediator.Send(new AddCoffee(model.Name, model.Size));
        }
    }
}
