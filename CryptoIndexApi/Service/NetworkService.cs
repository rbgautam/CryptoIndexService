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
            PopulateCurrentTop100Rates();
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
            foreach (Data coin in coinData )
            {
                coin.guid = newGuid;
                coin.TIMESTAMP = timeStamp;
                mNetworkService.UpdateDbWithLatestRates(coin);
            }
        }

        public void PopulateCurrentTop100Rates()
        {
            var filteredlist = mCoinList.Take(100).ToList();
            mNetworkService.PopulateCurrentRates(filteredlist);
        }

    }
}