using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrytoIndex.Models
{
    public class CurrentPriceRaw
    {
        public string TYPE { get; set; }
        public string MARKET { get; set; }
        public string FROMSYMBOL { get; set; }
        public string TOSYMBOL { get; set; }
        public string FLAGS { get; set; }
        public double PRICE { get; set; }
        public double LASTUPDATE { get; set; }
        public double LASTVOLUME { get; set; }
        public double LASTVOLUMETO { get; set; }
        public string LASTTRADEID { get; set; }
        public double VOLUME24HOUR { get; set; }
        public double VOLUME24HOURTO { get; set; }
        public double OPEN24HOUR { get; set; }
        public double HIGH24HOUR { get; set; }
        public double LOW24HOUR { get; set; }
        public double CHANGE24HOUR { get; set; }
        public double CHANGEPCT24HOUR { get; set; }
        public double CHANGEDAY { get; set; }
        public double CHANGEPCTDAY { get; set; }
        public long SUPPLY{ get; set; }
        public double MKTCAP{ get; set; }
        public double TOTALVOLUME24H{ get; set; }
        public double TOTALVOLUME24HTO{ get; set; }

        public string ErrorMessage { get; set; }

    }
}
