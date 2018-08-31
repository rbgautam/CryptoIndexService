using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrytoIndex.Models
{
    public class CurrentPriceDisplay
    {
       
        public string FROMSYMBOL{ get; set; }
        public string TOSYMBOL{ get; set; }
        public string MARKET{ get; set; }
        public string PRICE{ get; set; }
        public string LASTUPDATE{ get; set; }
        public string LASTVOLUME{ get; set; }
        public string LASTVOLUMETO{ get; set; }
        public string LASTTRADEID{ get; set; }
        public string VOLUME24HOUR{ get; set; }
        public string VOLUME24HOURTO{ get; set; }
        public string OPEN24HOUR{ get; set; }
        public string HIGH24HOUR{ get; set; }
        public string LOW24HOUR{ get; set; }
        public string CHANGE24HOUR{ get; set; }
        public string CHANGEPCT24HOUR{ get; set; }
        public string CHANGEDAY{ get; set; }
        public string CHANGEPCTDAY{ get; set; }
        public string SUPPLY{ get; set; }
        public string MKTCAP{ get; set; }
        public string TOTALVOLUME24H{ get; set; }
        public string TOTALVOLUME24HTO{ get; set; }

        public string ErrorMessage { get; set; }
    }
}
