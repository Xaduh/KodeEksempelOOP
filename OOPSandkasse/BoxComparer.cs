using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSandkasse
{
    internal class BoxHeightComparer : IComparer<Box>
    {
        public int Compare(Box? x, Box? y)
        {
            return x.Højde.CompareTo(y.Højde);
        }
    }
    internal class BoxVolumeComparer : IComparer<Box>
    {
        public int Compare(Box? x, Box? y)
        {
            return x.GetVolume().CompareTo(y.GetVolume());
        }
    }
}
