using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    //2.Create a class called Book.
    class Book : IComparable<Book>
    {
/*4.Add the following Properties to the Book class – Title[string], 
 * Author[string], Published[DateTime], Pages[int] and Genre[Genre].*/
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Published { get; set; }
        public int Pages { get; set; }
        public string Genre { get; set; }
        public int Age { get; set; }
        //5.Create 3 constructors.  Link these constructors using this.
        public Book(string author, string title, DateTime published,int pages,string genre)
        {
            Title = title;
            Author = author;
            Published = published;
            Pages = pages;
            Genre = genre;
        }
        public Book (int age)
        {
            
        }
        //6.Override the ToString() method to display all properties.
        public override string ToString()
        {
            return string.Format($"{Author,-30}{Title,-30}{Pages,-15}{Genre,-15}{Published,-30}");
        }
        /*10.Add IComparable to enable you to sort the books by Author then 
         * Title.  Change the books to ensure two books are by the same author.*/
        public int CompareTo(Book other)
        {
            if (this.Author == other.Author)
            {
                return this.Title.CompareTo(other.Title);
            }
            return other.Author.CompareTo(this.Author);
        }
    }

    /*3.Add an enum called Genre which has the following options – 
     * Fiction/Biography/Computing/Literature. This is what i found while 
     * googling enum but i dont quite understand it so we're just going to use a string.*/
    enum Genre
    {
        Fiction,
        Biography,
        Computing,
        Literature
    }
}
