using Domain.Entities;
using Infrastructure.DataAcess;
using Services.Repositories.Abstractions;

namespace Infrastructure.Repositories.Implementations
{
    public class QuestionnaireRepository : Repository<Questionnaire>, IQuestionnaireRepository
    {
        public QuestionnaireRepository(MongoDB<Questionnaire> db) : base(db)
        {

        }
    }
}
