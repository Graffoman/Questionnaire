using Domain.Entities;
using MongoDB.Bson;
using Services.Contracts.UserDto;

namespace Services.Abstractions
{
    public interface IUserService
    {
        Task<List<User>> GetAllAsync();
        Task<User> GetByIdAsync(ObjectId id);
        Task<ObjectId> CreateAsync(CreateUserDto createUserDto);
        Task<bool> UpdateAsync(User user);
        Task<bool> DeleteByIdAsync(ObjectId id);
    }
}
