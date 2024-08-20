using AutoMapper;
using Domain.Entities;
using Services.Abstractions;
using Services.Contracts.OpenQuestionnaireDto;
using Services.Repositories.Abstractions;

namespace Services.Implementations
{
    public class OpenQuestionnaireService : IOpenQuestionnaireService
    {
        private readonly IMapper _mapper;
        private readonly IOpenQuestionnaireRepository _openQuestionnaireRepository;

        public OpenQuestionnaireService(IMapper mapper, IOpenQuestionnaireRepository openQuestionnaireRepository)
        {
            _mapper = mapper;
            _openQuestionnaireRepository = openQuestionnaireRepository;
        }

        public async Task<string> CreateAsync(CreateOpenQuestionnaireDto createOpenQuestionnaireDto)
        {
            var openQuestionnaire = _mapper.Map<OpenQuestionnaire>(createOpenQuestionnaireDto);
            await _openQuestionnaireRepository.AddAsync(openQuestionnaire, CancellationToken.None);
            return openQuestionnaire.Id;
        }

        public Task<bool> DeleteByIdAsync(string id)
        {
            return _openQuestionnaireRepository.DeleteAsync(id, CancellationToken.None);
        }

        public Task<List<OpenQuestionnaire>> GetAllAsync()
        {
            return _openQuestionnaireRepository.GetAllAsync(CancellationToken.None);
        }

        public Task<OpenQuestionnaire> GetByIdAsync(string id)
        {
            return _openQuestionnaireRepository.GetAsync(id, CancellationToken.None);
        }

        public Task<bool> UpdateAsync(OpenQuestionnaire openQuestionnaire)
        {
            return _openQuestionnaireRepository.UpdateAsync(openQuestionnaire, CancellationToken.None);
        }
    }
}
