using CryptoIndexRepository.Context;
using CrytoIndex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoIndexRepository
{
    public class Main
    {
        public Main()
        {
            TestDbCreation();
        }

        private void TestDbCreation()
        {
            try
            {
                using (var db = new CryptoIndexDbContext())
                {
                    var coin = new CryptoIndexDbContext.Coin { Symbol="TEST",guid= new Guid(), FullName = "test Coin" };
                    //var currPriceRaw = new CurrentPriceRaw { Symbol = "TEST", guid = new Guid() };
                    //var currPriceDisp = new CurrentPriceDisplay { Symbol = "TEST", guid = new Guid() };

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
    }
}
