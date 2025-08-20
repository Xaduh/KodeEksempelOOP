using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSandkasse
{
    internal class Bil
    {
        public Bil()
        {
            
        }
        public Bil(string mærke)
        {
            Mærke = mærke;
        }
        public Bil(string mærke, string model, int antalDøre, int hestekrafter) : this(mærke) 
        {
            Model = model;
            AntalDøre = antalDøre;
            Hestekrafter = hestekrafter;
        }
        // Propfull, sådan ser property og field sammenhængen ud.
        // private Field, indeholder vores data
        private string _mærke;

        // Property, bruges til at hente og gæmme data, fra private field
        public string Mærke 
		{
			get { return _mærke; }
			set { _mærke = value; }
		}

        // prop, shortform af propfull, .net autogenerere private field, inde bag i koden.
        public string Model { get; set; }
        public int AntalDøre { get; set; }
        public int Hestekrafter { get; set; }
        private int hastighed;

        // Udvidelse Type, El, Benzin, Diesel
        // public Type type { get; set; }

        public void Accelerer(int kmT)
        {
            hastighed += kmT;
            Console.WriteLine(hastighed);
        }

        // private void Test() { Console.WriteLine(); Console.WriteLine(); if (true) { Console.WriteLine(); } }

        public void Bremse(int kmT)
        {
            hastighed -= kmT;
            Console.WriteLine(hastighed);
        }

        public bool Stop()
        {
            return false;
        }

        public void HåndBremse()
        {
            hastighed = 0;
            Console.WriteLine("Parkeret");
        }
    }
}
