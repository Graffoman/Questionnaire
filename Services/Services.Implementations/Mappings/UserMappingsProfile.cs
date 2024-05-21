using AutoMapper;
using Domain.Entities;
using Services.Contracts.UserDto;

namespace Services.Implementations.Mappings
{
    public class UserMappingsProfile : Profile
    {
        public UserMappingsProfile()
        {
            CreateMap<CreateUserDto, User>();
        }
    }
}
