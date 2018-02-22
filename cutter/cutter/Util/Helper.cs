using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cutter.Util
{
    public class Helper
    {
        public static string buildEndpointUrl(string[] urlParts)
        {
            StringBuilder builder = new StringBuilder();
            foreach (string urlPart in urlParts)
            {
                builder.Append(urlPart);
            }
            return builder.ToString();
        }
    }
}
