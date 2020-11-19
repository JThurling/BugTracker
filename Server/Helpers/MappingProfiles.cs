using AutoMapper;
using Core.Models.Bugs;
using Core.Models.Inputs.Bug;
using Core.Models.Output.Bug;

namespace BugTracker.Server.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<BugInput, BugEntity>();
            CreateMap<BugEntity, BugOutput>();
                // .ForMember(m => m.Priority, o => o.MapFrom(f => f.Priority.ToString()));
        }
    }
}
