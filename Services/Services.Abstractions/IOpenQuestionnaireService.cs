using Domain.Entities;
using Services.Contracts.OpenQuestionnaireDto;

namespace Services.Abstractions
{
    public interface IOpenQuestionnaireService
    {
        Task<List<OpenQuestionnaire>> GetAllAsync();
        Task<OpenQuestionnaire> GetByIdAsync(string id);
        Task<string> CreateAsync(CreateOpenQuestionnaireDto createOpenQuestionnaireDto);
        Task<bool> UpdateAsync(OpenQuestionnaire openQuestionnaire);
        Task<bool> DeleteByIdAsync(string id);
    }
}
