using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrytoIndex.Models
{
    public class CurrentPriceRaw
    {
        public string TYPE;
        public string MARKET;
        public string FROMSYMBOL;
        public string TOSYMBOL;
        public string FLAGS;
        public double PRICE;
        public double LASTUPDATE;
        public double LASTVOLUME;
        public double LASTVOLUMETO;
        public string LASTTRADEID;
        public double VOLUME24HOUR;
        public double VOLUME24HOURTO;
        public double OPEN24HOUR;
        public double HIGH24HOUR;
        public double LOW24HOUR;
        public double CHANGE24HOUR;
        public double CHANGEPCT24HOUR;
        public double CHANGEDAY;
        public double CHANGEPCTDAY;
        public long SUPPLY;
        public double MKTCAP;
        public double TOTALVOLUME24H;
        public double TOTALVOLUME24HTO;

        public string ErrorMessage { get; set; }

    }
}
