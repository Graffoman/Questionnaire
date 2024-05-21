using Domain.Entities;
using Services.Contracts.QuestionnaireDto;

namespace Services.Abstractions
{
    public interface IQuestionnaireService
    {
        Task<List<Questionnaire>> GetAllAsync();
        Task<Questionnaire> GetByIdAsync(string id);
        Task<string> CreateAsync(CreateQuestionnaireDto createQuestionnaireDto);
        Task<bool> UpdateAsync(Questionnaire questionnaire);
        Task<bool> DeleteByIdAsync(string id);
    }
}
