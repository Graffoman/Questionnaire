using Domain.Entities.BaseClasses;
using Microsoft.EntityFrameworkCore;
using Services.Contracts.QuestionDto;
using Services.Repositories.Abstractions;

namespace Infrastructure.Repositories.Implementations
{
    public class QuestionRepository : Repository<Question>, IQuestionRepository
    {
        public QuestionRepository(DbContext context) : base(context)
        {
        }

        public Task<Guid> CreateQuestionAsync(CreateQuestionDto createQuestionDto)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Question>> GetAllQuestionsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Question> GetQuestionByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
