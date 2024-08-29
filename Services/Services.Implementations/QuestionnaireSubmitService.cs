using AutoMapper;
using Domain.Entities;
using Services.Abstractions;
using Services.Contracts.QuestionnaireSubmitDto;
using Services.Repositories.Abstractions;

namespace Services.Implementations
{
    public class QuestionnaireSubmitService : IQuestionnaireSubmitService
    {
        private readonly IMapper _mapper;
        private readonly IQuestionnaireSubmitRepository _questionnaireSubmitRepository;

        public QuestionnaireSubmitService(IMapper mapper, IQuestionnaireSubmitRepository questionnaireSubmitRepository)
        {
            _mapper = mapper;
            _questionnaireSubmitRepository = questionnaireSubmitRepository;
        }

        public async Task<string> CreateAsync(CreateQuestionnaireSubmitDto createQuestionnaireSubmitDto)
        {
            var questionnaireSubmit = _mapper.Map<QuestionnaireSubmit>(createQuestionnaireSubmitDto);
            await _questionnaireSubmitRepository.AddAsync(questionnaireSubmit, CancellationToken.None);
            return questionnaireSubmit.Id;
        }

        public Task<bool> DeleteByIdAsync(string id)
        {
            return _questionnaireSubmitRepository.DeleteAsync(id, CancellationToken.None);
        }

        public Task<List<QuestionnaireSubmit>> GetAllAsync()
        {
            return _questionnaireSubmitRepository.GetAllAsync(CancellationToken.None);
        }

        public Task<QuestionnaireSubmit> GetByIdAsync(string id)
        {
            return _questionnaireSubmitRepository.GetAsync(id, CancellationToken.None);
        }

        public Task<bool> UpdateAsync(QuestionnaireSubmit questionnaireSubmit)
        {
            return _questionnaireSubmitRepository.UpdateAsync(questionnaireSubmit, CancellationToken.None);
        }
    }
}
