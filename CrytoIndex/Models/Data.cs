using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CryptoIndexRepository.Context.CryptoIndexDbContext;

namespace CrytoIndex.Models
{
    public class Data
    {
        
        public string Id { get; set; }
        [Key]
        public Guid guid { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        [Key]
        public string Symbol { get; set; }
        public CurrentPriceRaw currentPriceRaw { get; set; }
        public CurrentPriceDisplay currentPriceDisplay { get; set; }

        public string CoinName { get; set; }
        public string FullName { get; set; }
        public string Algorithm { get; set; }
        public string ProofType { get; set; }
        public string FullyPremined { get; set; }
        public string TotalCoinSupply { get; set; }
        public string BuiltOn { get; set; }
        public string SmartContractAddress { get; set; }
        public string PreMinedValue { get; set; }
        public string TotalCoinsFreeFloat { get; set; }
        public string SortOrder { get; set; }
        public long SortOrderValue { get; set; }

        public bool Sponsored{ get; set; }
        public bool IsTrading { get; set; }

        public long TotalCoinSupplyValue;

        public Data()
        {
            currentPriceRaw = new CurrentPriceRaw();
            currentPriceDisplay = new CurrentPriceDisplay();
        }
        public long getTotalCoinSupplyValue()
        {
            try
            {
                setTotalCoinSupplyValue(long.Parse(TotalCoinSupply));
            }
            catch (Exception)
            {
                setTotalCoinSupplyValue(0);

            }
            
            return TotalCoinSupplyValue;
        }

        public void setTotalCoinSupplyValue(long value)
        {
            this.TotalCoinSupplyValue = value;
        }

        public long getSortOrderValue()
        {
            try
            {
                setSortOrderValue(long.Parse(SortOrder));
            }
            catch (Exception)
            {
                setSortOrderValue(0);

            }

            return SortOrderValue;
        }

        public void setSortOrderValue(long value)
        {
            this.SortOrderValue = value;
        }

        public DateTime TIMESTAMP { get; set; }
        public Coin ConvertToCoin() {

            Coin coin = new Coin {
                Algorithm = this.Algorithm,
                BuiltOn = this.BuiltOn,
                CHANGE24HOUR = this.currentPriceRaw.CHANGE24HOUR,
                CHANGEDAY = this.currentPriceRaw.CHANGEDAY,
                CHANGEPCT24HOUR = this.currentPriceRaw.CHANGEPCT24HOUR,
                CHANGEPCTDAY = this.currentPriceRaw.CHANGEPCTDAY,
                CoinName = this.CoinName,
                FROMSYMBOL = this.currentPriceRaw.FROMSYMBOL,
                FullName = this.FullName,
                FullyPremined = this.FullyPremined,
                HIGH24HOUR = this.currentPriceRaw.HIGH24HOUR,
                Id = this.Id,
                ImageUrl = this.ImageUrl,
                IsTrading = this.IsTrading,
                LASTTRADEID = this.currentPriceRaw.LASTTRADEID,
                LASTUPDATE = this.currentPriceRaw.LASTUPDATE,
                LASTVOLUME = this.currentPriceRaw.LASTVOLUME,
                LASTVOLUMETO = this.currentPriceRaw.LASTVOLUMETO,
                LOW24HOUR = this.currentPriceRaw.LOW24HOUR,
                MARKET = this.currentPriceRaw.MARKET,
                MKTCAP = this.currentPriceRaw.MKTCAP,
                OPEN24HOUR = this.currentPriceRaw.OPEN24HOUR,
                Name = this.Name,
                PreMinedValue = this.PreMinedValue,
                PRICE = this.currentPriceRaw.PRICE,
                ProofType= this.ProofType,
                SmartContractAddress = this.SmartContractAddress,
                SortOrder = this.SortOrder,
                SortOrderValue = this.SortOrderValue,
                Sponsored = this.Sponsored,
                SUPPLY = this.currentPriceRaw.SUPPLY,
                Symbol = this.Symbol,
                TOSYMBOL = this.currentPriceRaw.TOSYMBOL,
                TotalCoinsFreeFloat = this.TotalCoinsFreeFloat,
                TotalCoinSupply = this.TotalCoinSupply,
                TotalCoinSupplyValue = this.TotalCoinSupplyValue,
                TOTALVOLUME24H = this.currentPriceRaw.TOTALVOLUME24H,
                TOTALVOLUME24HTO = this.currentPriceRaw.TOTALVOLUME24HTO,
                Url = this.Url,
                VOLUME24HOUR = this.currentPriceRaw.VOLUME24HOUR,
                VOLUME24HOURTO = this.currentPriceRaw.VOLUME24HOURTO,
                TIMESTAMP = this.TIMESTAMP,
                guid = this.guid
            };

            return coin;
        }
    }
}