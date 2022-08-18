using AutoMapper;
using PlatformService.DTOs;
using PlatformService.Models;

namespace PlatformService.Profiles
{
    public class PlatformProfile : Profile
    {
        public PlatformProfile()
        {
            CreateMap<CreateUserDTO, User>();
            CreateMap<User, CreateUserDTO>();
            CreateMap<User, ReadUserDTO>();
            CreateMap<UpdateUserDTO, User>();
        }
    }
}
