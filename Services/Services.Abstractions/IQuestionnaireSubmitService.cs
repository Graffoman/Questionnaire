using Domain.Entities;
using Services.Contracts.QuestionnaireSubmit;

namespace Services.Abstractions
{
    public interface IQuestionnaireSubmitService
    {
        Task<List<QuestionnaireSubmit>> GetAllAsync();
        Task<QuestionnaireSubmit> GetByIdAsync(string id);
        Task<string> CreateAsync(CreateQuestionnaireSubmitDto createQuestionnaireSubmitDto);
        Task<bool> UpdateAsync(QuestionnaireSubmit questionnaireSubmit);
        Task<bool> DeleteByIdAsync(string id);
    }
}
