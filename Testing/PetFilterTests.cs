using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace APITesting
{
    public class PetFilterTests
    {
        [Fact]
        public async Task TestPetFilterDisntictValues()
        {
            var client = new Client().client;
            var response = await client.GetAsync("https://api20211105132600.azurewebsites.net/api/PetFilter/DistinctValues");

            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task TestPetFilterDisntictFilterCriteria()
        {
            var client = new Client().client;
            var response = await client.GetAsync("https://api20211105132600.azurewebsites.net/api/PetFilter/DistinctFilterCriteria");

            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task TestPetFilter()
        {
            var client = new Client().client;
            var response = await client.GetAsync("https://api20211105132600.azurewebsites.net/api/PetFilter");

            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task TestPetFilterID()
        {
            var client = new Client().client;
            var response = await client.GetAsync("https://api20211105132600.azurewebsites.net/api/PetFilter/single/6");

            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task TestPetFilterByValue()
        {
            var client = new Client().client;
            var response = await client.GetAsync("https://api20211105132600.azurewebsites.net/api/PetFilter/ByValue/Dog");

            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task TestPetFilterByCriteria()
        {
            var client = new Client().client;
            var response = await client.GetAsync("https://api20211105132600.azurewebsites.net/api/PetFilter/ByCriteria/Category");

            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task TestPetFilterByMonth()
        {
            var client = new Client().client;
            var response = await client.GetAsync("https://api20211105132600.azurewebsites.net/api/PetFilter/ByMonth/10");

            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
