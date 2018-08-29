using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CrytoIndex.Models
{
    public class Data
    {
        public string Id;
        public string Url;
        public string ImageUrl;
        public string Name;
        public string Symbol;
        public CurrentPriceRaw currentPriceRaw { get; set; }
        public CurrentPriceDisplay currentPriceDisplay { get; set; }

        public string CoinName;
        public string FullName;
        public string Algorithm;
        public string ProofType;
        public string FullyPremined;
        public string TotalCoinSupply;
        public string BuiltOn;
        public string SmartContractAddress;
        public string PreMinedValue;
        public string TotalCoinsFreeFloat;
        public string SortOrder;
        public long SortOrderValue;

        public bool Sponsored;
        public bool IsTrading;

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
                setTotalCoinSupplyValue(long.Parse(getTotalCoinSupply()));
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
                setSortOrderValue(long.Parse(getSortOrder()));
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
        public string getId()
        {
            return Id;
        }

        public void setId(string id)
        {
            this.Id = id;
        }

        public string getUrl()
        {
            return Url;
        }

        public void setUrl(string url)
        {
            this.Url = url;
        }

        public string getImageUrl()
        {
            return ImageUrl;
        }

        public void setImageUrl(string imageUrl)
        {
            this.ImageUrl = imageUrl;
        }

        public string getName()
        {
            return Name;
        }

        public void setName(string name)
        {
            this.Name = name;
        }

        public string getSymbol()
        {
            return Symbol;
        }

        public void setSymbol(string symbol)
        {
            this.Symbol = symbol;
        }

        public string getCoinName()
        {
            return CoinName;
        }

        public void setCoinName(string coinName)
        {
            this.CoinName = coinName;
        }

        public string getFullName()
        {
            return FullName;
        }

        public void setFullName(string fullName)
        {
            this.FullName = fullName;
        }

        public string getAlgorithm()
        {
            return Algorithm;
        }

        public void setAlgorithm(string algorithm)
        {
            this.Algorithm = algorithm;
        }

        public string getProofType()
        {
            return ProofType;
        }

        public void setProofType(string proofType)
        {
            this.ProofType = proofType;
        }

        public string getFullyPremined()
        {
            return FullyPremined;
        }

        public void setFullyPremined(string fullyPremined)
        {
            this.FullyPremined = fullyPremined;
        }

        public string getTotalCoinSupply()
        {
            return TotalCoinSupply;
        }

        public void setTotalCoinSupply(string totalCoinSupply)
        {
            this.TotalCoinSupply = totalCoinSupply;
        }

        public string getBuiltOn()
        {
            return BuiltOn;
        }

        public void setBuiltOn(string builtOn)
        {
            this.BuiltOn = builtOn;
        }

        public string getSmartContractAddress()
        {
            return SmartContractAddress;
        }

        public void setSmartContractAddress(string smartContractAddress)
        {
            this.SmartContractAddress = smartContractAddress;
        }

        public string getPreMinedValue()
        {
            return PreMinedValue;
        }

        public void setPreMinedValue(string preMinedValue)
        {
            this.PreMinedValue = preMinedValue;
        }

        public string getTotalCoinsFreeFloat()
        {
            return TotalCoinsFreeFloat;
        }

        public void setTotalCoinsFreeFloat(string totalCoinsFreeFloat)
        {
            this.TotalCoinsFreeFloat = totalCoinsFreeFloat;
        }

        public string getSortOrder()
        {
            return SortOrder;
        }

        public void setSortOrder(string sortOrder)
        {
            this.SortOrder = sortOrder;
        }

        public bool getSponsored()
        {
            return Sponsored;
        }

        public void setSponsored(bool sponsored)
        {
            this.Sponsored = sponsored;
        }

        public bool getIsTrading()
        {
            return IsTrading;
        }

        public void setIsTrading(bool isTrading)
        {
            this.IsTrading = isTrading;
        }

    }
}