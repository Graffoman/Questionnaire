using Domain.Entities;
using MongoDB.Bson;
using Services.Contracts.QuestionnaireDto;

namespace Services.Repositories.Abstractions
{
    public interface IQuestionnaireRepository : IRepository<Questionnaire>
    {
        Task<ICollection<Questionnaire>> GetAllQuestionnairesAsync();
        Task<Questionnaire> GetQuestionnaireByIdAsync(ObjectId id);
        Task<ObjectId> CreateQuestionnaireAsync(CreateQuestionnaireDto createQuestionnaireDto);
        Task<ObjectId> UpdateQuestionnaireAsync(Questionnaire questionnaire);
        Task<ObjectId> DeleteQuestionnaireByIdAsync(ObjectId id);
        Task<ObjectId> DeleteQuestionnaireAsync(Questionnaire questionnaire);
    }
}
