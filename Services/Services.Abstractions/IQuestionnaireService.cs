using Domain.Entities;
using Services.Contracts.QuestionnaireDto;

namespace Services.Abstractions
{
    public interface IQuestionnaireService
    {
        Task<Questionnaire> GetByIdAsync(Guid id);
        Task<Guid> CreateAsync(CreateQuestionnaireDto createQuestionnaireDto);
    }
}
