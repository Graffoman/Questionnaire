using Domain.Entities;
using Services.Abstractions;
using Services.Contracts.QuestionnaireDto;

namespace Services.Implementations
{
    public class QuestionnaireService : IQuestionnaireService
    {
        public Task<Guid> CreateAsync(CreateQuestionnaireDto createQuestionnaireDto)
        {
            throw new NotImplementedException();
        }

        public Task<Questionnaire> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
