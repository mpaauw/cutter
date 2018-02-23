using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cutter.Util
{
    public class Helper
    {
        private const string URL_DELIMITER = "/";

        public static string BuildEndpointUrl(string[] urlParts)
        {
            return string.Join(URL_DELIMITER, urlParts);
        }
    }
}
