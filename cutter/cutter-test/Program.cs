using cutter.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cutter_test
{
    class Program
    {
        static void Main(string[] args)
        {
            WebService service = new WebService();
            var item = service.GetItemAsync(16424954).Result;
            string lol = "test";
        }
    }
}
