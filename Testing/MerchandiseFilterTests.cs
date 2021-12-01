using System;
using Xunit;
using API;
using Microsoft.AspNetCore.Hosting;
using API.Models;
using API.Controllers;
using Microsoft.AspNetCore.TestHost;
using System.Threading.Tasks;
using FluentAssertions;
using System.Net;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;

namespace APITesting
{
    public class MerchandiseFilterTests
    {
        //public UnitTests() 
        //{
        //var webBuilder = new WebHostBuilder();
        //webBuilder.UseStartup<Startup>();
        //var server = new TestServer(webBuilder);
        //}


        [Fact]
        public async Task TestMerchandiseFilterCategories()
        {
            var client = new Client().client;
            var response = await client.GetAsync("https://api20211105132600.azurewebsites.net/api/MerchandiseFilter/Categories");

            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            IEnumerable<string> list = await response.Content.ReadAsAsync<IEnumerable<string>>();

            list.Count().Should().BeInRange(8, 9);
        }

        [Fact]
        public async Task TestMerchandiseFilter()
        {
            var client = new Client().client;
            var response = await client.GetAsync("https://api20211105132600.azurewebsites.net/api/MerchandiseFilter");

            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task TestMerchandiseFilterId()
        {
            var client = new Client().client;
            var response = await client.GetAsync("https://api20211105132600.azurewebsites.net/api/MerchandiseFilter/4");

            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task TestMerchandiseFilterByCategory()
        {
            var client = new Client().client;
            var response = await client.GetAsync("https://api20211105132600.azurewebsites.net/api/MerchandiseFilter/ByCategory/Dog");

            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task TestMerchandiseFilterByMonth()
        {
            var client = new Client().client;
            var response = await client.GetAsync("https://api20211105132600.azurewebsites.net/api/MerchandiseFilter/ByMonth/10");

            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
