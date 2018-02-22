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

        public async Task<T> getContentAsync<T>(string endpoint)
        {
            T content = default(T);
            HttpResponseMessage response = await this.client.GetAsync(endpoint);
            if(response.IsSuccessStatusCode)
            {
                content = await response.Content.ReadAsAsync<T>();
            }
            else
            {
                throw new HttpException(Constants.HTTP_EXCEPTION_GENERIC);
            }
            return content;
        }

    }
}
