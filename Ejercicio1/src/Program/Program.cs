using System;
using System.Collections.Generic;
namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            Shelve shelve1 = new Shelve("EstanteA1", "Ficción");
            Sector sector1 = new Sector("A1");
            sector1.AddShelve(shelve1);
            shelve1.AddBook(book1);
            sector1.GetEstantes();
            shelve1.GetLibros();
        }
    }
}