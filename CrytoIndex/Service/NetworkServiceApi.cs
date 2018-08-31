using CrytoIndex.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrytoIndex.Service
{
    public class NetworkServiceApi
    {
        private List<Data> mCoinList { get; set; }
        public NetworkServiceApi(List<Data> coinList)
        {
            this.mCoinList = coinList;
        }

        public List<Data> GetCoinList()
        {

            try
            {



                var client = new RestClient("https://min-api.cryptocompare.com/data/all/coinlist");

                var request = new RestRequest(Method.GET);



                //// or automatically deserialize result
                //// return content type is sniffed but can be explicitly set via RestClient.AddHandler();
                IRestResponse<CoinListApiResponse> response = client.Execute<CoinListApiResponse>(request);

                JObject rss = JObject.Parse(response.Content);
                string rssTitle = (string)rss["Message"];

                var coins = from p in rss["Data"]
                            select p;
                var allCoinsList = coins.ToList();

                foreach (var item in allCoinsList)
                {
                    mCoinList.Add(JsonConvert.DeserializeObject<Data>(item.FirstOrDefault().ToString()));

                }








                // easy async support
                //client.ExecuteAsync(request, response =>
                //{
                //    JObject rss = JObject.Parse(response.Content);
                //    string rssTitle = (string)rss["Message"];

                //    var coins = from p in rss["Data"]
                //                select p;
                //    var allCoinsList = coins.ToList();

                //    foreach (var item in allCoinsList)
                //    {
                //        mCoinList.Add(JsonConvert.DeserializeObject<Data>(item.FirstOrDefault().ToString()));

                //    }

                //});



            }
            catch (Exception ex)
            {

                throw ex;
            }

            return mCoinList.OrderBy(o => o.getSortOrderValue()).ToList();
        }

        public void PopulateCurrentRates(List<Data> mCoinList)
        {
            int count = 0;
            foreach (var coin in mCoinList)
            {
                count++;
                var symbol = coin.Symbol;
                try
                {


                    var apiPath = "https://min-api.cryptocompare.com/data/pricemultifull?fsyms=" + symbol + "&tsyms=USD&extraParams=your_app_name";
                    var client = new RestClient(apiPath);
                    var request = new RestRequest(Method.GET);



                    //// or automatically deserialize result
                    //// return content type is sniffed but can be explicitly set via RestClient.AddHandler();
                    IRestResponse<CoinListApiResponse> response = client.Execute<CoinListApiResponse>(request);

                    JObject rss = JObject.Parse(response.Content);

                    string rssResponse = (string)rss["Response"];


                    if (rssResponse!= null && rssResponse.Equals("Error")) {
                        string rssMessage = (string)rss["Message"];
                        if (!string.IsNullOrEmpty(rssMessage)) {
                            coin.currentPriceRaw.ErrorMessage = rssMessage;
                            coin.currentPriceDisplay.ErrorMessage = rssMessage;
                        }
                        continue;
                    }

                    //Set raw data
                    var ratesRaw = (from p in rss["RAW"][symbol]
                                select p).ToList();

                    if (ratesRaw != null) {
                        foreach (var rate in ratesRaw)
                        {
                            coin.currentPriceRaw = JsonConvert.DeserializeObject<CurrentPriceRaw>(rate.FirstOrDefault().ToString());
                        }
                    }


                    //Set display data
                    var ratesDisplay = (from p in rss["DISPLAY"][symbol]
                                    select p).ToList();

                    if (ratesDisplay != null)
                    {
                        foreach (var rate in ratesDisplay)
                        {
                            coin.currentPriceDisplay = JsonConvert.DeserializeObject<CurrentPriceDisplay>(rate.FirstOrDefault().ToString());
                        }
                    }


                }
                catch (Exception ex)
                {

                    throw;
                }

            }
        }
    }
}
