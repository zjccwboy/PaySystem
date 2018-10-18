using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTools
{

    public class CnArea
    {
        public AreaGlobal global { get; set; }
        public AreaItem[] items { get; set; }
    }

    public class AreaGlobal
    {
    }

    public class AreaItem : Item
    {
        public string _mnemonic { get; set; }
        public string _parent { get; set; }
    }
}
