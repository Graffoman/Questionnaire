using Domain.Entities.BaseClasses;
using Services.Abstractions;
using Services.Contracts.QuestionDto;

namespace Services.Implementations
{
    public class QuestionService : IQuestionService
    {
        public Task<Guid> CreateAsync(CreateQuestionDto createQuestionDto)
        {
            throw new NotImplementedException();
        }

        public Task<Question> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
