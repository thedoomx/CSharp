using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private static void AddGenresToBook(int bookID, List<string> genres)
        {
            using (BookDBDataContext context = new BookDBDataContext())
            {
                foreach (var genre in genres)
                {
                    AddGenre(genre);

                    var bookGenres = new BookGenre()
                    {
                        BookID = bookID,
                        GenreID = GetGenre(genre).ID
                    };

                    context.BookGenres.InsertOnSubmit(bookGenres);
                }

                context.SubmitChanges();
            }
        }

        private static void AddAuthorsToBook(int bookID, List<Author> bookAuthors)
        {
            using (BookDBDataContext context = new BookDBDataContext())
            {
                foreach (var author in bookAuthors)
                {
                    var bookAuthor = new BookAuthor()
                    {
                        BookID = bookID,
                        AuthorID = author.ID
                    };
                    context.BookAuthors.InsertOnSubmit(bookAuthor);
                }

                context.SubmitChanges();
            }
        }

        private static Book AddBook(string title, string description, DateTime datePublished, int pages, string isbn, int bookCopies)
        {
            using (BookDBDataContext context = new BookDBDataContext())
            {
                Book newBook = new Book()
                {
                    Title = title,
                    BookResume = description,
                    DatePublished = datePublished,
                    Pages = pages,
                    ISBN = isbn
                };

                context.Books.InsertOnSubmit(newBook);

                while (bookCopies > 0)
                {
                    var bookCopy = new BookCopy()
                    {
                        Book = newBook
                    };
                    context.BookCopies.InsertOnSubmit(bookCopy);
                    bookCopies--;
                }

                //var existing = context.Authors.FirstOrDefault(a => a.FirstName.Contains("G"));

                //if (existing != null)
                //{
                //    var bookAuthor = new BookAuthor()
                //    {
                //        BookID = newBook.ID,
                //        AuthorID = existing.ID
                //    };
                //}

                //var bookGenre = new BookGenre()
                //{
                //    BookID = newBook.ID
                //};

                context.SubmitChanges();
                return newBook;
            }
        }

        private static void AddAuthor(string firstName, string lastName, DateTime yearBorn, DateTime yearDied)
        {
            using (var context = new BookDBDataContext())
            {
                if (context.Authors.FirstOrDefault(author => author.FirstName == firstName && author.LastName == lastName) == null)
                {
                    Author temp = new Author()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        YearBorn = yearBorn,
                        YearDied = yearDied
                    };

                    context.Authors.InsertOnSubmit(temp);
                    context.SubmitChanges();
                }
            }
        }

        //private static Author GetAuthor(Author author)
        //{
        //    using (var context = new BookDBDataContext())
        //    {
        //        return context.Authors.FirstOrDefault(a => a.FirstName.Equals(author.FirstName) && a.LastName.Equals(author.LastName));
        //    }
        //}

        private static void AddGenre(string genre)
        {
            using (var context = new BookDBDataContext())
            {
                if (context.Genres.FirstOrDefault(g => g.Name.Equals(genre)) == null)
                {
                    Genre gen = new Genre()
                    {
                        Name = genre
                    };

                    context.Genres.InsertOnSubmit(gen);
                    context.SubmitChanges();
                }
            }
        }

        private static Genre GetGenre(string genre)
        {
            using (var context = new BookDBDataContext())
            {
                return context.Genres.FirstOrDefault(g => g.Name.Equals(genre));
            }
        }

        private static void AddUser(string firstName, string lastName, string pseudonim, string email, int phone)
        {
            using (var context = new BookDBDataContext())
            {
                if (context.Users.FirstOrDefault(user => user.Email == email) == null)
                {

                    User temp = new User()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Pseudonim = pseudonim,
                        Email = email,
                        Phone = phone
                    };

                    context.Users.InsertOnSubmit(temp);
                    context.SubmitChanges();
                }
            }
        }

        public static List<Book> GetAllBooksSortedByTitle()
        {
            List<Book> result = new List<Book>();

            using (var context = new BookDBDataContext())
            {
                result = (from book in context.Books
                          orderby book.Title ascending
                          select book).ToList();

            }

            return result;
        }

        public static List<Book> GetAllBooksSortedByAuthor()
        {
            List<Book> result = new List<Book>();
            using (var context = new BookDBDataContext())
            {
                result = (from book in context.Books
                          join bookAuthor in context.BookAuthors on book.ID equals bookAuthor.BookID
                          join author in context.Authors on bookAuthor.AuthorID equals author.ID
                          orderby author.FirstName ascending
                          select book).ToList();
            }

            return result;
        }

        public static List<Book> GetAllBooksSortedByGenre()
        {
            List<Book> result = new List<Book>();

            using (var context = new BookDBDataContext())
            {
                result = (from book in context.Books
                          from bookGenre in book.BookGenres
                          orderby bookGenre.Genre ascending
                          select book).ToList();

            }

            return result;
        }

        public static List<Genre> GetAllGenresByAuthor(Author author)
        {
            List<Genre> result = new List<Genre>();

            using (var context = new BookDBDataContext())
            {
                result = (from genre in context.Genres
                          join bookGenre in context.BookGenres on genre.ID equals bookGenre.GenreID
                          join books in context.Books on bookGenre.BookID equals books.ID
                          join bookAuthors in context.BookAuthors on books.ID equals bookAuthors.BookID
                          join authors in context.Authors on bookAuthors.AuthorID equals authors.ID
                          where authors.FirstName.Equals(author.FirstName) && authors.LastName.Equals(author.LastName)
                          select genre).ToList();

                //var res = from a in context.Authors
                //          where a.FirstName == author
                //          from bookauth in a.BookAuthors
                //          from bookgenre in bookauth.Book.BookGenres
                //          select bookgenre.Genre.Name;
            }

            return result;
        }

        public static List<Book> GetAllBooksByAuthor(Author author)
        {
            List<Book> result = new List<Book>();

            using (var context = new BookDBDataContext())
            {
                result = (from book in context.Books
                          from a in book.BookAuthors
                          where a.Author.Equals(author)
                          select book).ToList();
            }

            return result;
        }

        public static void GetInfoByISBN(string isbn)
        {
            StringBuilder sb = new StringBuilder();

            using (var context = new BookDBDataContext())
            {
                Book book = context.Books.FirstOrDefault(b => b.ISBN.Equals(isbn));
                Author author = (from a in context.Authors
                                 from ba in a.BookAuthors
                                 where ba.Book.ISBN.Equals(isbn)
                                 select a).SingleOrDefault();

                sb.Append(book.Title).Append(" by ").Append(author.FirstName + author.LastName);
            }

            Console.WriteLine(sb.ToString());
        }

        public static void GetInfoByTitle(string title)
        {
            using (var context = new BookDBDataContext())
            {
                Book book = context.Books.FirstOrDefault(b => b.Title.Contains(title));

                Console.WriteLine(book.Title);
            }
        }

        public static void LoanBookToUser(User user, Book book)
        {
            using (var context = new BookDBDataContext())
            {
                bool alreadyLoaned = (from bu in context.BookUsers
                                  where bu.UserID == user.ID
                                    && bu.BookCopy.Book.ID == book.ID
                                    && bu.ReturnDate >= DateTime.Now.Date
                                  select 1).Count() > 0;

                if (alreadyLoaned == true)
                {
                    throw new ArgumentException("You have already loaned this book!");
                }


                BookCopy availableCopy = (from bu in context.BookUsers
                                          where bu.BookCopy.BookID == book.ID
                                          && bu.ReturnDate == null
                                          select bu.BookCopy).FirstOrDefault();

                var avail = (from bc in context.BookCopies
                             where bc.BookID == book.ID
                                 && bc.BookUsers.Count() == 0
                             select bc).FirstOrDefault();

                if (availableCopy == null)
                {
                    throw new ArgumentException("There is no available copy of this book!");
                }

            }
        }
    }
}
