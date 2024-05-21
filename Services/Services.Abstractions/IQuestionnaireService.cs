using Domain.Entities;
using MongoDB.Bson;
using Services.Contracts.QuestionnaireDto;

namespace Services.Abstractions
{
    public interface IQuestionnaireService
    {
        Task<List<Questionnaire>> GetAllAsync();
        Task<Questionnaire> GetByIdAsync(ObjectId id);
        Task<ObjectId> CreateAsync(CreateQuestionnaireDto createQuestionnaireDto);
        Task<bool> UpdateAsync(Questionnaire questionnaire);
        Task<bool> DeleteByIdAsync(ObjectId id);
    }
}
