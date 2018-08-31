using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
        

    }
}