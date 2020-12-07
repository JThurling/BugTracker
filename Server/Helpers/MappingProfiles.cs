using AutoMapper;
using BugTracker.Shared.Models;
using BugTracker.Shared.Models.Inputs;
using BugTracker.Shared.Models.Output.Users;
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
            CreateMap<BugEntity, BugOutput>()
                .ForMember(d => d.Comments, o => o.MapFrom(f => f.Comments))
                .ForMember(d => d.SubTasks, o => o.MapFrom(f => f.SubTasks));
            CreateMap<CommentInput, Comments>();
            CreateMap<Comments, CommentOutput>();
            CreateMap<SubTaskInput, SubTask>();
            CreateMap<SubTask, SubTaskOutput>();
            CreateMap<ApplicationUser, UserOutput>();
            CreateMap<UserInput, ApplicationUser>()
                .ForMember(d => d.UserName, o => o.MapFrom(m => m.Email));
        }
    }
}
