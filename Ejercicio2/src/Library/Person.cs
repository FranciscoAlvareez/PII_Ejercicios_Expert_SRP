using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{    
    public class Person
    {
        public string Name{get;set;}
        private string PhoneNumber{get;set;}
        private string Domicilio{get;set;}
        public Person(string name, string numero, string domicilio)
        {
            this.Name=name;
            this.PhoneNumber=numero;
            this.Domicilio = domicilio;
        }
    }
}