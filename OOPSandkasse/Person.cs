using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSandkasse
{
    internal class Person
    {
        public Person()
        {
            tæller = tæller + 1;
            ID = tæller;
        }
        public static int tæller;
        // Field
        private int ID;
        public string fornavn { get; set; }
        public string efternavn { get; set; }
        public string adresse { get; set; }
        public int postnr { get; set; }
        public string by { get; set; }

        public int getID()
        {
            return ID;
        }

        public void skrivPersonInstans()
        {

        }

        public static void skrivInstans(Person person)
        {
            Console.WriteLine(person.ID);
            Console.WriteLine(person.fornavn);
            Console.WriteLine(person.efternavn);
            Console.WriteLine(tæller);
        }
    }
}
