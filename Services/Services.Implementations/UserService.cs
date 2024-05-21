using Domain.Entities;
using MongoDB.Bson;
using Services.Abstractions;
using Services.Contracts.UserDto;

namespace Services.Implementations
{
    public class UserService : IUserService
    {
        public Task<ObjectId> CreateAsync(CreateUserDto createUserDto)
        {
            throw new NotImplementedException();
        }

        public Task<ObjectId> DeleteByIdAsync(ObjectId id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByIdAsync(ObjectId id)
        {
            throw new NotImplementedException();
        }

        public Task<ObjectId> UpdateAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
