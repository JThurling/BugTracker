using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BugTracker.Server;
using BugTracker.Server.Extension;
using Core.Interfaces.Services;
using Core.Models.Bugs;
using Core.Models.Inputs.Bug;
using FluentAssertions;
using Moq;
using Newtonsoft.Json;
using Xunit;

namespace BugTrackerTestSuite.IntegrationTests
{
    public class BugController : IClassFixture<WebAppFactory<Startup>>
    {
        private readonly HttpClient _client;
        private readonly Mock<IBugService> _mockRepo;

        public BugController(WebAppFactory<Startup> factory)
        {
            _client = factory.CreateClient();
            _mockRepo = new Mock<IBugService>();
        }

        [Fact]
        public async Task CreateBug_WhenCalled_CreatesNewBug()
        {
            var response = await _client.PostAsync("api/bug", new StringContent(JsonConvert.SerializeObject(new BugInput
            {
                Bug = "This is a bug that I made",
                Deadline = DateTime.Today,
                Priority = Priority.Low,
                Status = Status.Open
            }), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task CreateBug_WhenCalled_FailsBug()
        {
            var response = await _client.PostAsync("api/bug", new StringContent(JsonConvert.SerializeObject(new BugInput
            {
                Deadline = DateTime.Today,
                Priority = Priority.Low,
                Status = Status.Open
            }), Encoding.UTF8, "application/json"));
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task GetBug_WhenCalled_GetsListOfBugs()
        {
            var response = await _client.GetAsync("api/bug");
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
