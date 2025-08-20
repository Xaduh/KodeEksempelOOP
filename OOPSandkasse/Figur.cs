using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSandkasse
{
    abstract class Figur
    {
        public int Højde { get; set; }
        public int Bredde { get; set; }

        public virtual double Rumfang()
        {
            return Højde * Bredde;
        }
    }
}
