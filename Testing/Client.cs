using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace APITesting
{
    class Client
    {
        public HttpClient client { get; set; }
        
        public Client() 
        {
            var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());

            client = server.CreateClient();
        }
    }
}
