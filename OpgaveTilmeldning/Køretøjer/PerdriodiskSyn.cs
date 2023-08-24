using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveTilmeldning.Køretøjer
{
    internal class PerdriodiskSyn
    {
        public int? SynInterval { get; set; }

        public PerdriodiskSyn(int synInterval)
        {
            SynInterval = 2;
        }
    }
}
