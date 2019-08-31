using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocean.sdk.entity
{
    class ApplicationResp
    {
        public string message { get; set; }

        public string data { get; set; }

        public int    status { get; set; }

        public string errorCode { get; set; }

        public string errorMessage { get; set; }

        public string exception { get; set; }
    }
}
