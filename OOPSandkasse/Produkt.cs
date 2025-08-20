using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OOPSandkasse
{
//    Opgave 6
//Opret en klasse produkt.

//Opgave 7
//Produkt skal have 3 egenskaber, pris, kg og stoerrelse.

//Opgave 8
//Lav en metode for produktets pris, hvor den regner momsen ud af produktet automatisk når man sætter prisen. 
    internal class Produkt
    {
        private double _moms;

        public double Moms
        {
            get { return _moms; }
            set { _moms = value; }
        }
        private double _pris;
        public double Pris
        {
            get { return _pris; }
            set { _pris = PrisInformation(value); }
        }
        private double PrisInformation(double pris)
        {
            Moms = pris * 0.25;
            return pris;
        }

        public int kg { get; set; }
        public string størrelse { get; set; }


    }
}
