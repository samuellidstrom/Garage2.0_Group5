using AutoMapper;
using Garage2._0_Group5.Models.Entities;
using Garage2._0_Group5.Models.ViewModels;

namespace Garage2._0_Group5.AutomapperConfig
{
    public class GarageMappings : Profile
    {
        public GarageMappings()
        {
            CreateMap<Member, MemberCreateViewModel>().ReverseMap();
        }
    }
}
