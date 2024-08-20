using Domain.Entities;
using Infrastructure.DataAcess;
using Services.Repositories.Abstractions;

namespace Infrastructure.Repositories.Implementations
{
    public class QuestionnaireSubmitRepository : Repository<QuestionnaireSubmit>, IQuestionnaireSubmitRepository
    {
        public QuestionnaireSubmitRepository(MongoDB<QuestionnaireSubmit> db) : base(db)
        {
            
        }
    }
}
