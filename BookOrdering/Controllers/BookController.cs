using System.Collections.Generic;
using System.Linq;
using Application.Command.Book.CreateBook;
using Application.Command.Book.DeleteBook;
using Application.Command.Book.UpdateBook;
using Application.Query.BookQueries.GetBook;
using Application.Query.BookQueries.GetBooks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookOrdering.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        
        private readonly ISender _sender;

        public BooksController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var books = await _sender.Send(new GetBooksQuery());
            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var book = await _sender.Send(new GetBookQuery{Id = id});
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> AddBook(CreateBookCommand request)
        {
            var result = await _sender.Send(request);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id, UpdateBookDto bookDto)
        {
            await _sender.Send(new UpdateBookCommand(id, bookDto));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteBook(int id)
        {
            await _sender.Send(new DeleteBookCommand(id));
            return NoContent();
        }
    }
}