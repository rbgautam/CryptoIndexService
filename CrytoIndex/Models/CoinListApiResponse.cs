using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrytoIndex.Models
{
    public class CoinListApiResponse
    {
        public string Response;
        public string Message;
        public List<Data> Data = new List<Data>();
        public string BaseImageUrl;
        public string BaseLinkUrl;
        

        public String getResponse()
        {
            return Response;
        }

        public void setResponse(String response)
        {
            this.Response = response;
        }

        public String getMessage()
        {
            return Message;
        }

        public void setMessage(String message)
        {
            this.Message = message;
        }

        public List<Data> getData()
        {
            return Data;
        }

        public void setData(List<Data> data)
        {
            this.Data = data;
        }

        public String getBaseImageUrl()
        {
            return BaseImageUrl;
        }

        public void setBaseImageUrl(String baseImageUrl)
        {
            this.BaseImageUrl = baseImageUrl;
        }

        public String getBaseLinkUrl()
        {
            return BaseLinkUrl;
        }

        public void setBaseLinkUrl(String baseLinkUrl)
        {
            this.BaseLinkUrl = baseLinkUrl;
        }

        
    }
}
