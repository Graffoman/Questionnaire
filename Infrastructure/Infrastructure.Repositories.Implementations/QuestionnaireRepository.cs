using Domain.Entities;
using MongoDB.Bson;
using Services.Contracts.QuestionnaireDto;
using Services.Repositories.Abstractions;

namespace Infrastructure.Repositories.Implementations
{
    public class QuestionnaireRepository : Repository<Questionnaire>, IQuestionnaireRepository
    {
        public Task<ObjectId> CreateQuestionnaireAsync(CreateQuestionnaireDto createQuestionnaireDto)
        {
            throw new NotImplementedException();
        }

        public Task<ObjectId> DeleteQuestionnaireAsync(Questionnaire questionnaire)
        {
            throw new NotImplementedException();
        }

        public Task<ObjectId> DeleteQuestionnaireByIdAsync(ObjectId id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Questionnaire>> GetAllQuestionnairesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Questionnaire> GetQuestionnaireByIdAsync(ObjectId id)
        {
            throw new NotImplementedException();
        }

        public Task<ObjectId> UpdateQuestionnaireAsync(Questionnaire questionnaire)
        {
            throw new NotImplementedException();
        }
    }
}
