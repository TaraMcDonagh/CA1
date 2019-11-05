using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    class Book
    {
         /*Provide public accessors for these properties with auto-implemented Getters 
        and Setters for each*/
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Published { get; set; }
        public int Pages { get; set; }
        public string Genre { get; set; }

        public Book(string author, string title, DateTime published,int pages,string genre)
        {
            Title = title;
            Author = author;
            Published = published;
            Pages = pages;
            Genre = genre;
        }
        public override string ToString()
        {
            return string.Format($"");
        }
    }

    //This is what i found while googling enum but i dont quite understand it so we're just going to use a string.
    enum Genre
    {
        Fiction,
        Biography,
        Computing,
        Literature
    }
}
