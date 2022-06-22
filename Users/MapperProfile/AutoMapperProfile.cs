using AutoMapper;
using DataAccess.Models;
using Users.Dto;

namespace Users.MapperProfile
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateUserDto, User>();
        }
    }
}
