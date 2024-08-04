using Domain.Entities.BaseClasses;
using Domain.Entities.Enums;
using Domain.Entities;

namespace Services.Contracts.QuestionnaireDto
{
    public class UpdateQuestionnaireDto
    {
        public ICollection<Question> Questions { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public User Author { get; set; }
        public DateTime CreationDate { get; set; }
        public QuestionnaireState State { get; set; }
        public User LastChangedBy { get; set; }
    }
}
