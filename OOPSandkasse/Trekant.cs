using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSandkasse
{
    internal class Trekant : Figur
    {
        public override double Rumfang()
        {
            return Højde * Bredde / 2;
        }
    }
}
