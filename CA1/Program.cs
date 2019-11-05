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
            //create 5 Player objects
            Book Book1 = new Book("James Joyce", "Ulysses", new DateTime(1922, 02, 02),730, "Literature");
            Book Book2 = new Book("B Kerighan and D Ritchie ", "The C Programming Language", new DateTime(1978, 02, 28), 279, "Computing");
            Book Book3 = new Book("Walter Isaacson", "Steve Jobs", new DateTime(2011, 10, 24), 627, "Biography");
            Book Book4 = new Book("JRR Tolkin", "The Hobbit", new DateTime(1937, 09, 21), 210, "Fiction");
            Book Book5 = new Book("James Joyce", "Portrait of the Artist", new DateTime(1922, 02, 02), 730, "Literature");
        }
    }
}
