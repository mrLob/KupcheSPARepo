using AutoMapper;
using KupcheAspNetCore.DTO;
using KupcheAspNetCore.Models;

namespace KupcheAspNetCore.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Users, UserDto>();
            CreateMap<UserDto, Users>();   
        }
    }
}