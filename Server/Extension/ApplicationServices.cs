using AutoMapper;
using BugTracker.Server.Helpers;
using Core.Interfaces.Services;
using Core.Models;
using Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BugTracker.Server.Extension
{
    public static class ApplicationServices
    {
        public static void ConfigureAppServices(this IServiceCollection service)
        {
            service.AddScoped<IBugService, BugService>();
            service.AddAutoMapper(typeof(MappingProfiles));
            service.AddScoped<ICommentService, CommentService>();
        }
    }
}
