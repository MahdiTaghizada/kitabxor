using Kitabxor.Application.Features.MediatorDesignPattern.Commands.AdminCommands;
using Kitabxor.Application.Features.MediatorDesignPattern.Commands.TagCommands;
using Kitabxor.Application.Features.MediatorDesignPattern.Queries.AdminQueries;
using Kitabxor.Application.Features.MediatorDesignPattern.Queries.TagQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kitabxor.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AdminsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> AdminList()
        {
            var value = await _mediator.Send(new GetAdminQuery());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAdmin(CreateAdminCommand command)
        {
            await _mediator.Send(command);
            return Ok("elave edildi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAdmin(int id)
        {
            await _mediator.Send(new RemoveAdminCommand(id));
            return Ok("silindi");
        }

        [HttpGet("GetAdminById")]
        public async Task<IActionResult> GetAdminById(int id)
        {
            var value = await _mediator.Send(new GetAdminByIdQuery(id));
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAdmin(UpdateAdminCommand command)
        {
            await _mediator.Send(command);
            return Ok("yenilendi");
        }
    }
}
