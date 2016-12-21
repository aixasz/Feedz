using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
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
            var data1 = await GetData();
            return data1.Concat(GetData().Result);
        }

        private async Task<string[]> GetData()
        {
            // Just Comment
            return await Task.Run(() =>
            {
                DoSomeThing();
                return new[] { "value1", "value2" };
            });
        }

        private static void DoSomeThing()
        {
            Thread.Sleep(1);
        }
    }
}
