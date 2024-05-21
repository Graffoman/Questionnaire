using Domain.Entities;
using MongoDB.Bson;
using Services.Contracts.QuestionnaireDto;

namespace Services.Abstractions
{
    public interface IQuestionnaireService
    {
        Task<ICollection<Questionnaire>> GetAllAsync();
        Task<Questionnaire> GetByIdAsync(ObjectId id);
        Task<ObjectId> CreateAsync(CreateQuestionnaireDto createQuestionnaireDto);
        Task<ObjectId> UpdateAsync(Questionnaire questionnaire);
        Task<ObjectId> DeleteByIdAsync(ObjectId id);
    }
}
