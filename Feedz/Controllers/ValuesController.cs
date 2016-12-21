using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Feedz.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public async Task<IEnumerable<string>> Get()
        {
            return GetData().Result;
        }

        private Task<string[]> GetData()
        {
            return Task.Run(() => new[] { "value1", "value2" });
        }
    }
}
