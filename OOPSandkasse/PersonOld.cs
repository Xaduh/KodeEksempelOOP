using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OOPSandkasse
{
    internal class PersonOld : IComparable<PersonOld>, IComparer<PersonOld>
    {
        public string Navn { get; set; }
        public string Efternavn { get; set; }
        public string Adresse { get; set; }
        public string Tlf { get; set; }

        public void OpretPerson(string fornavn, string efternavn, string adresse, string telefon)
        {
            Navn = fornavn;
            Efternavn = efternavn;
            Adresse = adresse;  
            Tlf = telefon;
        }

        public void UdskrivPerson()
        {
            Console.WriteLine($"Navn: {Navn} {Efternavn},Adresse: {Adresse},Telefon nummer: {Tlf}");
        }

        public static void WritePerson(PersonOld person)
        {

        }

        public int CompareTo(PersonOld? other)
        {
            return Navn.CompareTo(other.Navn);
        }

        //public int Compare(Person? x, Person? y)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
