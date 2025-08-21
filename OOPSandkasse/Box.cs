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
    internal class Box
    {
        public Box(BoxType bType)
        {
            Type = bType;
        }
        public BoxType Type { get; set; }
        
        // Private field med Underscore
        private int _myVar;
        public int MyProperty => _myVar;
        public static Box operator +(Box a, Box b)
        {
            double test = (6 + 10) * 0.95;
            if(a.Type == BoxType.lille && b.Type == BoxType.lille)
            {
                return new Box(BoxType.mellem);
            }
            else if (a.Type == BoxType.mellem && b.Type == BoxType.mellem)
            {
                return new Box(BoxType.stor);
            }
            else if (a.Type != b.Type)
            {
                return new Box(BoxType.error);
            }
            else return new Box(BoxType.lille);
        }
    }
}
