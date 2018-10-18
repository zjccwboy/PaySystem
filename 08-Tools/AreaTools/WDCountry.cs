using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTools
{

    public class WDCountry
    {
        public CountryGlobal global { get; set; }
        public CountryItem[] items { get; set; }
    }

    public class CountryGlobal
    {
    }

    public class CountryItem : Item
    {
        public string _gArea { get; set; }
        public string _gContinent { get; set; }
        public string _isComm { get; set; }
        public string _mnemonic { get; set; }
        public string _firstCode { get; set; }
    }
}
