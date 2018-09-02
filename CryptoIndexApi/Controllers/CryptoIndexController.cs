﻿using CryptoIndexApi.Service;
using CrytoIndex.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace CryptoIndexApi.Controllers
{
    public class CryptoIndexController : ApiController
    {
        [HttpGet]
        public IEnumerable<Data> Coindata()
        {
            NetworkService networkService = new NetworkService();
            
            return networkService.GetAllCoinData(); 
        }

        [HttpGet]
        public void RefreshCoindata()
        {
            NetworkService networkService = new NetworkService();

            networkService.RefreshCoinData();
        }
    }
}
