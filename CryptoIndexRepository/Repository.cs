using CryptoIndexRepository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CryptoIndexRepository.Context.CryptoIndexDbContext;

namespace CryptoIndexRepository
{
    public class Repository
    {
        public void TestDbCreation()
        {
            try
            {
                using (var db = new CryptoIndexDbContext())
                {
                    var coin = new CryptoIndexDbContext.Coin { Symbol = "TEST", guid = Guid.NewGuid(), FullName = "test Coin" };

                    db.Coins.Add(coin);
                    //db.PriceRaw.Add(currPriceRaw);
                    //db.PriceDisplay.Add(currPriceDisp);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool RefreshCoinDb(Coin coin)
        {
            bool result = true;
            //TODO: see if can be done async
            //TODO: see if can be done in bulk
            try
            {
                using (var db = new CryptoIndexDbContext())
                {
                    db.Coins.Add(coin);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                result = false;

            }

            return result;
        }

        public IEnumerable<Coin> GetAllCoinData()
        {
            try
            {
                using (var db = new CryptoIndexDbContext())
                {
                    return db.Coins.OrderBy(o=>o.SortOrderValue).ToList();
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
