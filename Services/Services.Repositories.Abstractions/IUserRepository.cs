using Domain.Entities;
using MongoDB.Bson;
using Services.Contracts.UserDto;

namespace Services.Repositories.Abstractions
{
    public interface IUserRepository : IRepository<User>
    {
        Task<ICollection<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(ObjectId id);
        Task<ObjectId> CreateUserAsync(CreateUserDto createUserDto);
        Task<ObjectId> UpdateUserAsync(User user);
        Task<ObjectId> DeleteUserByIdAsync(ObjectId id);
        Task<ObjectId> DeleteUserAsync(User user);
    }
}
