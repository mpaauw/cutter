using cutter.Types;
using System;
using System.Collections.Generic;
using System.Web;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using cutter.Util;

namespace cutter.Services
{
    public class WebService
    {
        private HttpClient client;

        public WebService()
        {
            this.client = new HttpClient();
        }

        public async Task<T> getContentAsync<T>(string id, string pathObject)
        {
            T content = default(T);
            string endpoint = buildEndpointUrl(new string[] { Constants.URL_SCHEME, Constants.URL_HOST, Constants.URL_PATH, pathObject, id, Constants.PATH_FORMAT });
            HttpResponseMessage response = await this.client.GetAsync(endpoint);
            if(response.IsSuccessStatusCode)
            {
                content = await response.Content.ReadAsAsync<T>();
            }
            return content;
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
