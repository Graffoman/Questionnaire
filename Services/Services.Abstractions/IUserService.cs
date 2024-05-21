using Domain.Entities;
using Services.Contracts.UserDto;

namespace Services.Abstractions
{
    public interface IUserService
    {
        Task<List<User>> GetAllAsync();
        Task<User> GetByIdAsync(string id);
        Task<string> CreateAsync(CreateUserDto createUserDto);
        Task<bool> UpdateAsync(User user);
        Task<bool> DeleteByIdAsync(string id);
    }
}
