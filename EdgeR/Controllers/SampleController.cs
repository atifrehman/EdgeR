using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;


namespace EdgeR.Controllers
{
    public class SampleController : ApiController
    {
        [HttpGet]
        public IEnumerable<string> RandomCompute()
        {
            Random random = new Random();
            int miliseconds = random.Next(100, 1500);
            Thread.Sleep(miliseconds);
            return new string[] { "Processing Time: "+miliseconds };
        }
    }
}
