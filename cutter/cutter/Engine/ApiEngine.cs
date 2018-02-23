using cutter.Services;
using cutter.Types;
using cutter.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cutter.Engine
{
    public class ApiEngine
    {
        private WebService webService;
        private readonly string GET_ITEM_ENDPOINT;
        private readonly string GET_USER_ENDPOINT;
        private readonly string GET_MAX_ITEM_ENDPOINT;

        public ApiEngine()
        {
            this.webService = new WebService();
            this.GET_ITEM_ENDPOINT = Helper.buildEndpointUrl(new string[] { Constants.URL_SCHEME, Constants.URL_HOST, Constants.URL_PATH, Constants.PATH_ITEM, "{0}", Constants.PATH_FORMAT });
            this.GET_USER_ENDPOINT = Helper.buildEndpointUrl(new string[] { Constants.URL_SCHEME, Constants.URL_HOST, Constants.URL_PATH, Constants.PATH_USER, "{0}", Constants.PATH_FORMAT });
            this.GET_MAX_ITEM_ENDPOINT = Helper.buildEndpointUrl(new string[] { Constants.URL_SCHEME, Constants.URL_HOST, Constants.URL_PATH, Constants.PATH_MAX_ITEM, Constants.PATH_FORMAT });
        }

        public Item GetItem(string id)
        {
            return this.webService.getContentAsync<Item>(String.Format(this.GET_ITEM_ENDPOINT, id)).Result;
        }

        public User GetUser(string id)
        {
            return this.webService.getContentAsync<User>(String.Format(this.GET_USER_ENDPOINT, id)).Result;
        }

        public Item GetMaxItem()
        {
            string id = this.webService.getContentAsync<string>(this.GET_MAX_ITEM_ENDPOINT).Result;
            return GetItem(id);
        }

    }
}
