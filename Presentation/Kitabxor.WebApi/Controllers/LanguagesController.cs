using Kitabxor.Application.Features.MediatorDesignPattern.Commands.LanguageCommands;
using Kitabxor.Application.Features.MediatorDesignPattern.Queries.LanguageQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kitabxor.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LanguagesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> LanguageList()
        {
            var value = await _mediator.Send(new GetLanguageQuery());
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateLanguage(CreateLanguageCommand command)
        {
            await _mediator.Send(command);
            return Ok("elave edildi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteLanguage(int id)
        {
            await _mediator.Send(new RemoveLanguageCommand(id));
            return Ok("silindi");
        }
        [HttpGet("GetLanguageById")]
        public async Task<IActionResult> GetLanguageById(int id)
        {
            var value = await _mediator.Send(new GetLanguageByIdQuery(id));
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateLanguage(UpdateLanguageCommand command)
        {
            await _mediator.Send(command);
            return Ok("yenilendi");
        }
    }
}
