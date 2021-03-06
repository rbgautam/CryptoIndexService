﻿using CryptoIndexRepository.Context;
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

        public async Task<int> RefreshCoinDb(Coin coin)
        {
            int result = -1;
            //TODO: see if can be done async
            //TODO: see if can be done in bulk
            try
            {
                using (var db = new CryptoIndexDbContext())
                {
                    db.Coins.Add(coin);
                    result = await db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                result = -1;

            }

            return result;
        }

        public IEnumerable<Coin> GetAllCoinData(int count)
        {
            try
            {
                using (var db = new CryptoIndexDbContext())
                {

                    Guid latestguid = GetLatestGuid();

                    if (count == 0)
                        return db.Coins.Where(s=>s.guid == latestguid).OrderBy(o=>o.SortOrderValue).ToList();
                    else
                        return db.Coins.Where(s => s.guid == latestguid).OrderBy(o => o.SortOrderValue).Take(count).ToList();
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private Guid GetLatestGuid()
        {
            Guid result = new Guid();
            try
            {
                using (var db = new CryptoIndexDbContext()) {

                    result = db.Coins.Take(1).OrderByDescending(o => o.TIMESTAMP).Select(s => s.guid).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return result;
        }
    }
}
