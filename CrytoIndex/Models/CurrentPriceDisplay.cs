using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrytoIndex.Models
{
    public class CurrentPriceDisplay
    {
        public string FROMSYMBOL;
        public string TOSYMBOL;
        public string MARKET;
        public string PRICE;
        public string LASTUPDATE;
        public string LASTVOLUME;
        public string LASTVOLUMETO;
        public string LASTTRADEID;
        public string VOLUME24HOUR;
        public string VOLUME24HOURTO;
        public string OPEN24HOUR;
        public string HIGH24HOUR;
        public string LOW24HOUR;
        public string CHANGE24HOUR;
        public string CHANGEPCT24HOUR;
        public string CHANGEDAY;
        public string CHANGEPCTDAY;
        public string SUPPLY;
        public string MKTCAP;
        public string TOTALVOLUME24H;
        public string TOTALVOLUME24HTO;

        public string ErrorMessage { get; set; }
    }
}
