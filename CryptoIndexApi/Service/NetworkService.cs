﻿using CrytoIndex.Models;
using CrytoIndex.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CryptoIndexApi.Service
{
    public class NetworkService
    {
        public List<Data> mCoinList { get; set; }
        public NetworkServiceApi mNetworkService { get; set; }

        public List<Data> GetAllCoinData()
        {
            GetAllCoins();
            PopulateCurrentRates();
            return mCoinList;
        }

        public void GetAllCoins()
        {
            mCoinList = new List<Data>();
            mNetworkService = new CrytoIndex.Service.NetworkServiceApi(mCoinList);
            mCoinList = mNetworkService.GetCoinList();

        }

        public void RefreshCoinData()
        {
            DateTime timeStamp = DateTime.Now;
            Guid newGuid = Guid.NewGuid();
            var coinData = GetAllCoinData();
            foreach (Data coin in coinData)
            {
                coin.guid = newGuid;
                coin.TIMESTAMP = timeStamp;
                mNetworkService.UpdateDbWithLatestRates(coin);
            }
        }

        public void PopulateCurrentTop100Rates(int count = 100)
        {
            if (mCoinList.Count > 0)
            {
                //Always to be called after the GetAllCoins()
                var filteredlist = mCoinList.Take(count).ToList();
                mNetworkService.PopulateCurrentRates(filteredlist);
            }
        }

        public void PopulateCurrentRates()
        {
            if (mCoinList.Count > 0) {
                var filteredlist = mCoinList.ToList();
                mNetworkService.PopulateCurrentRates(filteredlist);
            }
               
        }

    }
}