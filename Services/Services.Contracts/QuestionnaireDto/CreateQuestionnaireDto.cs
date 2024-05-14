using Domain.Entities.Enums;
using Domain.Entities;
using Domain.Entities.BaseClasses;

namespace Services.Contracts.QuestionnaireDto
{
    public class CreateQuestionnaireDto
    {
        public ICollection<Question> Questions { get; set; }
        public User Author { get; set; }
        public DateTime CreationDate { get; set; }
        public QuestionnaireState State { get; set; }
        public DateTime LastChangeDate { get; set; }
        public User LastChangedBy { get; set; }
    }
}
