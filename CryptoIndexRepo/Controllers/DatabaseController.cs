using CryptoIndexRepo.Repository;
using CrytoIndex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CryptoIndexRepo.Controllers
{
    public class DatabaseController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            try
            {
                using (var db = new CyptoIndexContext())
                {
                    var coin = new Data { FullName = "test Coin" };
                    db.Coins.Add(coin);
                    db.SaveChanges();


                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}