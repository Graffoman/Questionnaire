using Domain.Entities;
using MongoDB.Bson;
using Services.Contracts.UserDto;
using Services.Repositories.Abstractions;

namespace Infrastructure.Repositories.Implementations
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public Task<ObjectId> CreateUserAsync(CreateUserDto createUserDto)
        {
            throw new NotImplementedException();
        }

        public Task<ObjectId> DeleteUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<ObjectId> DeleteUserByIdAsync(ObjectId id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<User>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByIdAsync(ObjectId id)
        {
            throw new NotImplementedException();
        }

        public Task<ObjectId> UpdateUserAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
