using Domain.Entities.BaseClasses;
using Services.Contracts.QuestionDto;

namespace Services.Abstractions
{
    public interface IQuestionService
    {
        Task<Question> GetByIdAsync(Guid id);
        Task<Guid> CreateAsync(CreateQuestionDto createQuestionDto);
    }
}
