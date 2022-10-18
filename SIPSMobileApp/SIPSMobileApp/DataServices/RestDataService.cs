using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPSMobileApp.DataServices
{
    internal class RestDataService : IRestDataService
    {
        private readonly HttpClient _httpClient;

        public RestDataService()
        {
            _httpClient = new HttpClient();
        }
    }
}
