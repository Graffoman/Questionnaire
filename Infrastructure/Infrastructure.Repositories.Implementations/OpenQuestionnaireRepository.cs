using Domain.Entities;
using Infrastructure.DataAcess;
using Services.Repositories.Abstractions;

namespace Infrastructure.Repositories.Implementations
{
    public class OpenQuestionnaireRepository : Repository<OpenQuestionnaire>, IOpenQuestionnaireRepository
    {
        public OpenQuestionnaireRepository(MongoDB<OpenQuestionnaire> db) : base(db)
        {
            
        }
    }
}
