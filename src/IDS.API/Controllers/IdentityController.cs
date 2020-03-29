using Base.API;
using IDS.API.Application.Commands.Identities;
using IDS.API.Application.Queries.Identities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IDS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private readonly IMediator mediator;

        public IdentityController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(PagingQueryResult<IdentityPagingQueryDTO>), 200)]
        public async Task<IActionResult> Get([FromQuery] IdentityPagingQuery query)
        {
            var resule = await mediator.Send(query);
            return Ok(resule);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(IdentityQueryDTO), 200)]
        public async Task<IActionResult> Get(string id)
        {
            var dto = await mediator.Send(new IdentityQuery(id));
            return Ok(dto);
        }

        [HttpPost]
        [ProducesResponseType(typeof(IdentityQueryDTO), 200)]
        public async Task<IActionResult> Post([FromBody]IdentityCreateCommand command)
        {
            var id = await mediator.Send(command);
            return await Get(id);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(202)]
        public async Task<IActionResult> Delete(string id)
        {
            await mediator.Send(new IdentityDeleteCommand(id));
            return NoContent();
        }
    }
}