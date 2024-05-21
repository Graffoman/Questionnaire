using Domain.Entities;
using MongoDB.Bson;
using Services.Abstractions;
using Services.Contracts.QuestionnaireDto;

namespace Services.Implementations
{
    public class QuestionnaireService : IQuestionnaireService
    {
        public Task<ObjectId> CreateAsync(CreateQuestionnaireDto createQuestionnaireDto)
        {
            throw new NotImplementedException();
        }

        public Task<ObjectId> DeleteByIdAsync(ObjectId id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Questionnaire>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Questionnaire> GetByIdAsync(ObjectId id)
        {
            throw new NotImplementedException();
        }

        public Task<ObjectId> UpdateAsync(Questionnaire questionnaire)
        {
            throw new NotImplementedException();
        }
    }
}
