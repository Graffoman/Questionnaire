using AutoMapper;
using Domain.Entities;
using MongoDB.Bson;
using Services.Abstractions;
using Services.Contracts.UserDto;
using Services.Repositories.Abstractions;

namespace Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<ObjectId> CreateAsync(CreateUserDto createUserDto)
        {
            var user = _mapper.Map<CreateUserDto, User>(createUserDto);
            await _userRepository.AddAsync(user, CancellationToken.None);
            return user.Id;
        }

        public Task<bool> DeleteByIdAsync(ObjectId id)
        {
            return _userRepository.DeleteAsync(id, CancellationToken.None);
        }

        public Task<List<User>> GetAllAsync()
        {
            return _userRepository.GetAllAsync(CancellationToken.None);
        }

        public Task<User> GetByIdAsync(ObjectId id)
        {
            return _userRepository.GetAsync(id, CancellationToken.None);
        }

        public Task<bool> UpdateAsync(User user)
        {
            return _userRepository.UpdateAsync(user, CancellationToken.None);
        }
    }
}
