using CryptoIndexApi.Service;
using CrytoIndex.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static CryptoIndexRepository.Context.CryptoIndexDbContext;

namespace CryptoIndexApi.Controllers
{
    public class CryptoIndexController : ApiController
    {
        [HttpGet]
        [Route("api/cryptoindex/Coindata/{count?}")]

        public IEnumerable<Coin> Coindata(int count=0)
        {
            //TODO: return Cached data if available
            NetworkService networkService = new NetworkService();
            var resultList = networkService.GetAllCoinData();
            if (count > 0) {
                resultList = resultList.Take(count).ToList();
            }
            return resultList;
        }

        [HttpGet]
        [Route("api/cryptoindex/Refresh")]

        public bool RefreshCoindata()
        {
            NetworkService networkService = new NetworkService();

            networkService.RefreshCoinData();

            return true;
        }
    }
}
