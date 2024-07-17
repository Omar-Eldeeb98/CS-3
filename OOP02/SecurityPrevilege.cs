using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    [Flags]
    public enum SecurityPrevilege
    {
        guest = 1, 
        Developer = 2, 
        secretary = 4,
        DBA = 8
    }
}
