using Domain.Entities;
using MongoDB.Bson;
using Services.Contracts.UserDto;

namespace Services.Abstractions
{
    public interface IUserService
    {
        Task<ICollection<User>> GetAllAsync();
        Task<User> GetByIdAsync(ObjectId id);
        Task<ObjectId> CreateAsync(CreateUserDto createUserDto);
        Task<ObjectId> UpdateAsync(User user);
        Task<ObjectId> DeleteByIdAsync(ObjectId id);
    }
}
