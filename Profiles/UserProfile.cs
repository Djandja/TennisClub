using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TennisClub.Models;
using TennisClub.Models.AccountViewModels;

namespace TennisClub.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, RegisterViewModel>().
                ForMember(dest =>
                    dest.Role,
                    opt => opt.MapFrom(src => src.RoleName))
                .ReverseMap();

              //  CreateMap<ApplicationUser, EditViewModel>().ReverseMap();


        }
    }
}
