using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource().ToList();
        }
        public BookModel GetBookById(int bookId)
        {
            return DataSource().Where(b => b.Id == bookId).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string bookTitle,string authorName)
        {
            return DataSource().Where(b => b.Title.Contains(bookTitle) || b.Author.Contains(authorName)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){ Id=1,Title="MVC",Author="Mahmoud" },
                new BookModel(){ Id=2,Title="C#",Author="Mohamed" },
                new BookModel(){ Id=3,Title="C++",Author="Alsaied" },
                new BookModel(){ Id=4,Title="MVC",Author="Mahmoud" },
                new BookModel(){ Id=5,Title="PHP",Author="Abou bakr" },
            };
        }
    }
}
