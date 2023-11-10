using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_11.Models
{
    public static class Seeder
    {
  
        public static List<Category> InitCategory()
        {
            List<Category> list = new List<Category>();
            list.Add(new Category()
            {
                Name="Книги"
            });
            list.Add(new Category()
            {
                Name = "Напитки"
            });
            list.Add(new Category()
            {
                Name = "Канцтовары"
            });
            list.Add(new Category()
            {
                Name = "Ноутбуки"
            });
            list.Add(new Category()
            {
                Name = "Смартфоны"
            });
            return list;
        }

        public static List<Product> InitProduct(List<Category> category)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product()
            {
                Name = "CocaCola",
                Price = 34m,
                Quantity = 170,
                Category = category.Where(e=>e.Name.Equals("Напитки")).First()
            });
            list.Add(new Product()
            {
                Name = "Гарри Поттер",
                Price = 778.4m,
                Quantity = 17,
                Category = category.Where(e => e.Name.Equals("Книги")).First()
            });
            list.Add(new Product()
            {
                Name = "MacBook",
                Price = 77834.4m,
                Quantity = 10,
                Category = category.Where(e => e.Name.Equals("Ноутбуки")).First()
            });
            list.Add(new Product()
            {
                Name = "LG",
                Price = 17834.4m,
                Quantity = 100,
                Category = category.Where(e => e.Name.Equals("Смартфоны")).First()
            });
            list.Add(new Product()
            {
                Name = "Ножницы",
                Price = 45.4m,
                Quantity = 67,
                Category = category.Where(e => e.Name.Equals("Канцтовары")).First()
            });
            list.Add(new Product()
            {
                Name = "Nokia",
                Price = 17834.4m,
                Quantity = 100,
                Category = category.Where(e => e.Name.Equals("Смартфоны")).First()
            });
            return list;
        }

    }
}
