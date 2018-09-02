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
            public string PRICE { get; set; }
            public string LASTUPDATE { get; set; }
            public string LASTVOLUME { get; set; }
            public string LASTVOLUMETO { get; set; }
            public string LASTTRADEID { get; set; }
            public string VOLUME24HOUR { get; set; }
            public string VOLUME24HOURTO { get; set; }
            public string OPEN24HOUR { get; set; }
            public string HIGH24HOUR { get; set; }
            public string LOW24HOUR { get; set; }
            public string CHANGE24HOUR { get; set; }
            public string CHANGEPCT24HOUR { get; set; }
            public string CHANGEDAY { get; set; }
            public string CHANGEPCTDAY { get; set; }
            public string SUPPLY { get; set; }
            public string MKTCAP { get; set; }
            public string TOTALVOLUME24H { get; set; }
            public string TOTALVOLUME24HTO { get; set; }

            public DateTime TIMESTAMP { get; set; }
            public string ErrorMessage { get; set; }
        }

    }
}
