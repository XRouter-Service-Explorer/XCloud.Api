using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XCloud.Api.Controllers.ViewModel
{
    public class ServiceResponseViewModel<T>
    {
        public T Reply { get; set; }
        public string Uuid { get; set; }
    }
}
