using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSandkasse
{
    internal class Kunde : PersonOld
    {
        //public string Navn { get; set; }
        //public string Efternavn { get; set; }
        //public string Adresse { get; set; }
        //public string Tlf { get; set; }
        public string Email { get; set; }
        public string RabatGruppe { get; set; }
        public double Totalkøb { get; set; }
    }
}
