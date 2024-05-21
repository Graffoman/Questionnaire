using AutoMapper;
using Domain.Entities;
using Services.Abstractions;
using Services.Contracts.QuestionnaireDto;
using Services.Repositories.Abstractions;

namespace Services.Implementations
{
    public class QuestionnaireService : IQuestionnaireService
    {
        private readonly IMapper _mapper;
        private readonly IQuestionnaireRepository _questionnaireRepository;

        public QuestionnaireService(IMapper mapper, IQuestionnaireRepository questionnaireRepository)
        {
            _mapper = mapper;
            _questionnaireRepository = questionnaireRepository;
        }

        public async Task<string> CreateAsync(CreateQuestionnaireDto createQuestionnaireDto)
        {
            var questionnaire = _mapper.Map<CreateQuestionnaireDto, Questionnaire>(createQuestionnaireDto);
            await _questionnaireRepository.AddAsync(questionnaire, CancellationToken.None);
            return questionnaire.Id;
        }

        public Task<bool> DeleteByIdAsync(string id)
        {
            return _questionnaireRepository.DeleteAsync(id, CancellationToken.None);
        }

        public Task<List<Questionnaire>> GetAllAsync()
        {
            return _questionnaireRepository.GetAllAsync(CancellationToken.None);
        }

        public Task<Questionnaire> GetByIdAsync(string id)
        {
            return _questionnaireRepository.GetAsync(id, CancellationToken.None);
        }

        public Task<bool> UpdateAsync(Questionnaire questionnaire)
        {
            return _questionnaireRepository.UpdateAsync(questionnaire, CancellationToken.None);
        }
    }
}
