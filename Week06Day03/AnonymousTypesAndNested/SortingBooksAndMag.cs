using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Book
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Book(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }
    }

    public class Magazine
    {
        public string Title { get; set; }
        public int ISBN { get; set; }

        public Magazine(string title, int isbn)
        {
            this.Title = title;
            this.ISBN = isbn;
        }
    }

    public static class MagazineAndBooksSorter
    {
        public static List<string> Sort(List<Book> books, List<Magazine> magazines)
        {
            List<string> result = new List<string>();

            var anonList = books.Select(x => new { name = x.Name, id = x.Id }).ToList();
            anonList.AddRange(magazines.Select(x => new { name = x.Title, id = x.ISBN }).ToList());

            anonList = anonList.OrderBy(x => x.name).ThenBy(x => x.id).ToList();
            foreach (var item in anonList)
            {
                result.Add(item.name);
            }

            return result;
        }

        private class Edition
        {
            public string EditionName { get; set; }
            public int Order { get; set; }
        }
    }
}
