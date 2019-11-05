/*  Student Number: S00185883   *
 *     Name: Tara McDonagh      *
 *            CA1               *
 *      Date: 05/11/2019        */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    class Program
    {
        static void Main(string[] args)
        {
      //7.Create 5 Book objects, you can use your own data or that in the screenshot.
            Book Book1 = new Book("James Joyce", "Ulysses", new DateTime(1922, 02, 02),730, "Literature");
            Book Book2 = new Book("B Kerighan and D Ritchie ", "The C Programming Language", new DateTime(1978, 02, 28), 279, "Computing");
            Book Book3 = new Book("Walter Isaacson", "Steve Jobs", new DateTime(2011, 10, 24), 627, "Biography");
            Book Book4 = new Book("JRR Tolkin", "The Hobbit", new DateTime(1937, 09, 21), 210, "Fiction");
            Book Book5 = new Book("James Joyce", "Portrait of the Artist", new DateTime(1916, 12, 29), 299, "Literature");

            //8.Add these Book objects to a List called ReadingList
            List<Book> ReadingList = new List<Book>();
            ReadingList.Add(Book1);
            ReadingList.Add(Book2);
            ReadingList.Add(Book3);
            ReadingList.Add(Book4);
            ReadingList.Add(Book5);
            //calling the Display method
            Display(ReadingList);

            //Sorting through the list and putting them in order by author
            ReadingList.Sort();
            Console.WriteLine("Sorted Books");
            foreach (var book in ReadingList)
            {
                Console.WriteLine(book);
            }
            //Displaying ages of books
            DisplayWithAge(ReadingList);

        }
        //9.Write a method in Program.cs which displays the books in the reading list.
        private static void Display(List<Book> books)
        {
            Console.WriteLine("{0,-30}{1,-30}{2,-15}{3,-15}{4,-30}", "Author", "Title", "Pages", "Genre", "Publication Date");
            foreach (Book book in books)
            {
                Console.WriteLine("{0,-10}", book);
            }

            Console.WriteLine();

        }
        /*11.In Program.cs write a method called DisplayWithAge which will look at each 
         * book and calculate the age in years of the book and display it .*/
         private static void DisplayWithAge(List<Book> books)
        {
            Console.WriteLine("Ages");
            foreach (Book book in books)
            {
                int years = DateTime.Now.Year - book.Published.Year;
                Console.WriteLine(years);
            }

            Console.WriteLine();
            

        }
    }
}
