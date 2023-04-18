using System;
using System.Collections.Generic;

namespace SRP
{
    public class Shelve
    {
        private string IdEstante{get;set;}
        public string Name{get; set;}
        public List<Book> Libros{get;set;}

        public Shelve(string Idestante, string name)
        {
            this.IdEstante = Idestante;
            this.Name = name;
            this.Libros = new List<Book>();
        }
        public void AddBook(Book libro)
        {
            this.Libros.Add(libro);
            Console.WriteLine("El libro se agrego adecuadamente");
        }
        public void GetLibros()
        {
            foreach (Book libros in Libros)
            {
                Console.WriteLine($"Los Libros del estante son: ");
                Console.WriteLine(libros.Title);
            }
        }
    }
}