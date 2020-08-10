using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XCloud.Api.Controllers.ViewModel
{
    public class EnterpriseServiceRequestViewModel
    {
        public string Service { get; set; }
        public string[] Params { get; set; }
        public string Endpoint { get; set; }
        public string NodePubKey { get; set; }
        public string RawTxHex { get; set; }
        public string Signature { get; set; }
    }
}
