using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace APITesting
{
    public class SessionTests
    {
        [Fact]
        public async Task TestSession()
        {
            var client = new Client().client;
            var response = await client.GetAsync("https://api20211105132600.azurewebsites.net/api/Session");

            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task TestSessionId()
        {
            var client = new Client().client;
            var response = await client.GetAsync("https://api20211105132600.azurewebsites.net/api/Session");

            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
