using cutter.Types;
using System;
using System.Collections.Generic;
using System.Web;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;

namespace cutter.Services
{
    public class WebService
    {
        private const string URL_SCHEME = "https://";
        private const string URL_HOST = "hacker-news.firebaseio.com/";
        private const string URL_PATH = "v0/";
        private const string PATH_ITEM = "item/";
        private const string PATH_FORMAT = ".json";

        private HttpClient client;

        public WebService()
        {
            this.client = new HttpClient();
        }

        public async Task<Item> GetItemAsync(int id)
        {
            Item item = null;
            string endpoint = buildEndpointUrl(new string[] { URL_SCHEME, URL_HOST, URL_PATH, PATH_ITEM, id.ToString(), PATH_FORMAT});
            HttpResponseMessage response = await this.client.GetAsync(endpoint);
            if(response.IsSuccessStatusCode)
            {
                item = await response.Content.ReadAsAsync<Item>();
            }
            else
            {
                throw new HttpException();
            }
            return item;
        }

        private string buildEndpointUrl(string[] urlParts)
        {
            StringBuilder builder = new StringBuilder();
            foreach(string urlPart in urlParts)
            {
                builder.Append(urlPart);
            }
            return builder.ToString();
        }
    }
}
