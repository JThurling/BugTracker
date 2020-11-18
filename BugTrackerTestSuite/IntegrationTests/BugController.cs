using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BugTracker.Server;
using BugTracker.Server.Extension;
using Core.Models.Bugs;
using Core.Models.Inputs.Bug;
using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using Xunit;

namespace BugTrackerTestSuite.IntegrationTests
{
    public class BugController : IClassFixture<WebAppFactory<Startup>>
    {
        private readonly HttpClient _client;
        public BugController(WebAppFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task CreateBug_WhenCalled_CreatesNewBug()
        {
            var response = await _client.PostAsync("api/Bug", new StringContent(JsonConvert.SerializeObject(new BugInput
            {
                Bug = "Hello",
                Deadline = DateTime.Today,
                Priority = Priority.Low,
                Status = Status.Open
            }), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            Assert.Contains("Hello", responseString);
        }

        [Fact]
        public async Task GetBug_WhenCalled_GetsListOfBugs()
        {
            var response = await _client.GetAsync("api/bug");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task GetBug_WhenCalled_GetSingleBug()
        {
            var response = await _client.GetAsync("api/Bug/1");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task DeleteBug_WhenCalled_DeletesBug()
        {
            var response = await _client.DeleteAsync("api/Bug");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
