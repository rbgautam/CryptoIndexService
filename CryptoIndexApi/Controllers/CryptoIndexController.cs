using CryptoIndexApi.Service;
using CrytoIndex.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
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
            var resultList = networkService.GetAllCoinData(count);
            return resultList;
        }

        [HttpGet]
        [Route("api/cryptoindex/Refresh")]

        public async Task<bool> RefreshCoindata()
        {
            NetworkService networkService = new NetworkService();

            await networkService.RefreshCoinData();

            return true;
        }
    }
}
