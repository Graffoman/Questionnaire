using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Services.Contracts.QuestionnaireDto;
using Services.Repositories.Abstractions;

namespace Infrastructure.Repositories.Implementations
{
    public class QuestionnaireRepository : Repository<Questionnaire>, IQuestionnaireRepository
    {
        public QuestionnaireRepository(DbContext context) : base(context)
        {
        }

        public Task<Guid> CreateQuestionnaireAsync(CreateQuestionnaireDto createQuestionnaireDto)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Questionnaire>> GetAllQuestionnairesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Questionnaire> GetQuestionnaireByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
