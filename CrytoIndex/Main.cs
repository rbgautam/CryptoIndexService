using CrytoIndex.Models;
using CrytoIndex.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CrytoIndex
{
    public class Main
    {
        public List<Data> mCoinList { get; set; }
        public NetworkService mNetworkService { get; set; }
        public Main()
        {
            mCoinList = new List<Data>();
            GetAllCoins();
            PopulateCurrentTop100Rates();

            var temp = mCoinList;


        }

        public void GetAllCoins()
        {

            mNetworkService = new NetworkService(mCoinList);
            mCoinList = mNetworkService.GetCoinList();

        }


        public void PopulateCurrentTop100Rates()
        {
            var filteredlist =  mCoinList.Take(100).ToList();
            mNetworkService.PopulateCurrentRates(filteredlist);
        }

    }
}
