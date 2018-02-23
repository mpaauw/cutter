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
        private readonly string GET_TOP_ITEMS_ENDPOINT;

        public ApiEngine()
        {
            this.webService = new WebService();
            this.GET_ITEM_ENDPOINT = Helper.BuildEndpointUrl(new string[] { Constants.URL_SCHEME, Constants.URL_HOST, Constants.URL_PATH, Constants.PATH_ITEM, "{0}", Constants.URL_FORMAT });
            this.GET_USER_ENDPOINT = Helper.BuildEndpointUrl(new string[] { Constants.URL_SCHEME, Constants.URL_HOST, Constants.URL_PATH, Constants.PATH_USER, "{0}", Constants.URL_FORMAT });
            this.GET_MAX_ITEM_ENDPOINT = Helper.BuildEndpointUrl(new string[] { Constants.URL_SCHEME, Constants.URL_HOST, Constants.URL_PATH, Constants.PATH_MAX_ITEM, Constants.URL_FORMAT });
            this.GET_TOP_ITEMS_ENDPOINT = Helper.BuildEndpointUrl(new string[] { Constants.URL_SCHEME, Constants.URL_HOST, Constants.URL_PATH, "{0}", Constants.URL_FORMAT });
        }

        public T GetItemByType<T>(int id)
        {
            return this.webService.GetContentAsync<T>(String.Format(this.GET_ITEM_ENDPOINT, id)).Result;
        }

        public Item GetMaxItem()
        {
            int id = this.webService.GetContentAsync<int>(this.GET_MAX_ITEM_ENDPOINT).Result;
            return GetItemByType<Item>(id);
        }

        public User GetUser(int id)
        {
            return this.webService.GetContentAsync<User>(String.Format(this.GET_USER_ENDPOINT, id)).Result;
        }

        public int[] GetItemIdsByCategory(string category)
        {
            return this.webService.GetContentAsync<int[]>(string.Format(this.GET_TOP_ITEMS_ENDPOINT, category)).Result;
        }


    }
}
