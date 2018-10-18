using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTools
{

    public class CnCity
    {
        public CityGlobal global { get; set; }
        public CityItem[] items { get; set; }
    }

    public class CityGlobal
    {
    }

    public class CityItem : Item
    {

        public string _isComm { get; set; }
        public string _mnemonic { get; set; }
        public string _parent { get; set; }

    }

    public class Item
    {
        public string key { get; set; }
        public string _name { get; set; }
    }
}
