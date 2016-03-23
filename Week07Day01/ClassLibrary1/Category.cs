using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        private static List<Category> categories = new List<Category>()
            {
                new Category { CategoryId = 1, CategoryName = "vw" },
                new Category { CategoryId = 2, CategoryName = "bmw" },
                new Category { CategoryId = 3, CategoryName = "audi" },
                new Category { CategoryId = 100, CategoryName = "mercedes" },
                new Category { CategoryId = 21, CategoryName = "opel" },
                new Category { CategoryId = 101, CategoryName = "honda" },
                new Category { CategoryId = 231, CategoryName = "fiat" }

            };

        public static IReadOnlyCollection<Category> ListCategories
        {
            get
            {
                return categories.AsReadOnly();
            }
        }

    }
}
