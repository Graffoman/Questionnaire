using Domain.Entities.BaseClasses;
using Services.Contracts.QuestionDto;

namespace Services.Repositories.Abstractions
{
    public interface IQuestionRepository : IRepository<Question>
    {
        Task<ICollection<Question>> GetAllQuestionsAsync();
        Task<Question> GetQuestionByIdAsync(Guid id);
        Task<Guid> CreateQuestionAsync(CreateQuestionDto createQuestionDto);
    }
}
