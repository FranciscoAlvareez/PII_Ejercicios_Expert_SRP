using System;
using System.Collections.Generic;

namespace SRP
{
    public class Sector
    {
        public string SectorName{get;set;}
        public List<Shelve> Estantes{get;set;}
        public Sector(string name)
        {
            this.SectorName=name;
            this.Estantes = new List<Shelve>();
        }
        public void AddShelve(Shelve estante)
        { 
            this.Estantes.Add(estante);
            Console.WriteLine("Estante agregado correctamente");
        }
        public void GetEstantes()
        {
            foreach (Shelve estante in Estantes)
            {
                Console.WriteLine($"Los estantes son: ");
                Console.WriteLine(estante.Name);
            }
        }
    }
}