using Kitabxor.Application.Features.MediatorDesignPattern.Commands.BookCommands;
using Kitabxor.Application.Features.MediatorDesignPattern.Queries.BookQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kitabxor.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BooksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> BookList()
        {
            var value = await _mediator.Send(new GetBookQuery());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook(CreateBookCommand command)
        {
            await _mediator.Send(command);
            return Ok("elave edildi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBook(int id)
        {
            await _mediator.Send(new RemoveBookCommand(id));
            return Ok("silindi");
        }

        [HttpGet("GetBookById")]
        public async Task<IActionResult> GetBookById(int id)
        {
            var value = await _mediator.Send(new GetBookByIdQuery(id));
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBook(UpdateBookCommand command)
        {
            await _mediator.Send(command);
            return Ok("yenilendi");
        }

    }
}
