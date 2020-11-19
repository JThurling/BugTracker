using AutoMapper;
using Core.Models.Bugs;
using Core.Models.Inputs.Bug;

namespace BugTracker.Server.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<BugInput, BugEntity>();
        }
    }
}
