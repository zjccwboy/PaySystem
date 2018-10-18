using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTools
{

    public class CnProvince
    {
        public ProvinceGlobal global { get; set; }
        public ProvinceItem[] items { get; set; }
    }

    public class ProvinceGlobal
    {
    }

    public class ProvinceItem : Item
    {
        public string _mnemonic { get; set; }
    }
}
