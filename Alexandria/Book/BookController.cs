using Microsoft.AspNetCore.Mvc;

namespace Alexandria.Book;

[ApiController]
[Route("/api/book")]
public class BookController(BookService _bookService) : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Book>> Get()
    {
        return Ok(_bookService.GetBooks());
    }

    [HttpPost]
    public ActionResult<Book> Post([FromBody] Book book)
    {
        _bookService.AddBook(book);
        return Ok(book);
    }

}