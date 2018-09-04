using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace CryptoIndexRepository.Context
{
    public class CryptoIndexDbContext : DbContext
    {
        public DbSet<Coin> Coins { get; set; }
        
        public CryptoIndexDbContext() : base("name=CryptoIndexDbContext")
        {
            // the terrible hack
            var ensureDLLIsCopied =
                    System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coin>().HasKey(t => new { t.Symbol, t.guid });
            
        }


        public class Coin
        {
            public string Id { get; set; }
            [Key]
            public Guid guid { get; set; }
            public string Url { get; set; }
            public string ImageUrl { get; set; }
            public string Name { get; set; }
            [Key]
            public string Symbol { get; set; }
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
            public bool Sponsored { get; set; }
            public bool IsTrading { get; set; }
            public long TotalCoinSupplyValue { get; set; }
            public string FROMSYMBOL { get; set; }
            public string TOSYMBOL { get; set; }
            public string MARKET { get; set; }
            public Nullable<double> PRICE { get; set; }
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
            public long SUPPLY { get; set; }
            public double MKTCAP { get; set; }
            public double TOTALVOLUME24H { get; set; }
            public double TOTALVOLUME24HTO { get; set; }

            public DateTime TIMESTAMP { get; set; }
            public string ErrorMessage { get; set; }
        }

    }
}
