using Domain.Entities;
using Services.Contracts.QuestionnaireDto;

namespace Services.Repositories.Abstractions
{
    public interface IQuestionnaireRepository : IRepository<Questionnaire>
    {
        Task<ICollection<Questionnaire>> GetAllQuestionnairesAsync();
        Task<Questionnaire> GetQuestionnaireByIdAsync(Guid id);
        Task<Guid> CreateQuestionnaireAsync(CreateQuestionnaireDto createQuestionnaireDto);
    }
}
