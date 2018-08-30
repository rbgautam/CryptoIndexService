using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CrytoIndex.Models;

namespace CryptoIndexRepo.Repository
{
    public class CyptoIndexContext:DbContext
    {
        public DbSet<Data> Coins { get; set; }
        public DbSet<CurrentPriceRaw> PriceRaw { get; set; }
        public DbSet<CurrentPriceDisplay> PriceDisplay { get; set; }
    }
}