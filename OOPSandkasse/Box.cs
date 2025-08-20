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
            boxType = bType;
        }

        public BoxType boxType { get; set; }

        public static Box operator +(Box a, Box b)
        {
            if(a.boxType == BoxType.lille && b.boxType == BoxType.lille)
            {
                return new Box(BoxType.mellem);
            }
            else if (a.boxType == BoxType.mellem && b.boxType == BoxType.mellem)
            {
                return new Box(BoxType.stor);
            }
            else if (a.boxType != b.boxType)
            {
                return new Box(BoxType.error);
            }
            else return new Box(BoxType.lille);
        }
    }
}
