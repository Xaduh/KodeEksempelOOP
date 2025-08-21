using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSandkasse
{
    enum BoxType : byte
    {
        lille,
        mellem,
        stor,
        error
    }
    internal class Box : IComparable<Box>
    {
        public Box()
        {
            
        }
        public Box(double højde, double bredde, double længde, BoxType bType)
        {
            Højde = højde;
            Bredde = bredde;
            Længde = længde;
            Type = bType;
        }
        public double Højde { get; set; }
        public double Bredde { get; set; }
        public double Længde { get; set; }
        public BoxType Type { get; set; }

        public override string ToString()
        {
            return $"Højde: {Højde} Bredde: {Bredde} Længde: {Længde}. Box type: {Type} ";
        }

        public double GetVolume()
        {
            return Højde * Bredde * Længde;
        }

        public int CompareTo(Box? other)
        {
            return Type.CompareTo(other.Type);
        }

        public static Box operator +(Box a, Box b)
        {
            //double test = (6 + 10) * 0.95;
            if(a.Type == BoxType.lille && b.Type == BoxType.lille)
            {
                return new Box((a.Højde + b.Højde) * 0.95, 
                    (a.Bredde + b.Bredde) * 0.95, (a.Længde + b.Længde) * 0.95, BoxType.mellem);
            }
            else return new Box((a.Højde + b.Højde) * 0.95,
                    (a.Bredde + b.Bredde) * 0.95, (a.Længde + b.Længde) * 0.95, BoxType.stor);
        }
    }
}
