namespace Alexandria.Book;

public class BookService
{
    private readonly List<Book?> _books = [];
    
    public List<Book?> GetBooks()
    {
        return _books;
    }

    public Book? GetBookById(int id)
    {
        return _books.Find(book => book != null && book.Id == id);
    }

    public Book? AddBook(Book? book)
    {
        _books.Add(book);
        foreach (var b in _books)
        {
            Console.WriteLine(b.Title);
        }
        return book;
    }
}