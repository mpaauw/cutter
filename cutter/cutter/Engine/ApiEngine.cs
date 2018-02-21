using cutter.Services;
using cutter.Types;
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

        public ApiEngine()
        {
            this.webService = new WebService();
        }

    }
}
