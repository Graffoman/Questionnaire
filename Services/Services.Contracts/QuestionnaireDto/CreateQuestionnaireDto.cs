using Domain.Entities.BaseClasses;
using Domain.Entities;

namespace Services.Contracts.QuestionnaireDto
{
    public class CreateQuestionnaireDto
    {
        public ICollection<Question> Questions { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public User Author { get; set; }
    }
}
