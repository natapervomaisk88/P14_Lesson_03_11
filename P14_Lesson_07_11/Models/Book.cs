using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_Lesson_07_11.Models
{
    public class Book
    {
        public string Id { get; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Book(string title, string author, int year)
        {
            Id = Guid.NewGuid().ToString();
            Title = title;
            Author = author;
            Year = year;
        }
        public override string ToString()
        {
            return $"{Id} : {Author} {Title} {Year}";
        }
    }
}
