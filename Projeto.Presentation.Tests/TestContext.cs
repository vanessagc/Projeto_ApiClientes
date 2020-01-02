using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Projeto.Presentation.Tests
{
    public class TestContext
    {
        public HttpClient Client { get; set; }

        private TestServer server;

        public TestContext()
        {
            server = new TestServer
                (new WebHostBuilder().UseStartup<Presentation.Api.Startup>());

            Client = server.CreateClient();
        }
    }
}
