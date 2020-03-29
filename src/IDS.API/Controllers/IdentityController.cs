using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IDS.API.Application.Commands.Identities;
using IDS.API.Application.Queries.Identities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> Get([FromQuery] IdentityPagingQuery query)
        {
            var resule = await mediator.Send(query);
            return Ok(resule);
        }

        [HttpGet("{id}")]
        //[ProducesResponseType(typeof(OrganizationIdentityQueryDTO), 200)]
        public async Task<IActionResult> Get(string id)
        {
            var dto = await mediator.Send(new IdentityQuery(id));
            return Ok(dto);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]IdentityCreateCommand command)
        {
            var id = await mediator.Send(command);
            return await Get(id);
        }
    }
}