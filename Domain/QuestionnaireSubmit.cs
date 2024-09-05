using Domain.Entities.BaseClasses;
using Domain.Entities.Interfaces;

namespace Domain.Entities
{
    public class QuestionnaireSubmit : IIdentifieble
    {
        public string Id { get; set; }
        public User Respondent { get; set; }
        public string OpenQuestionnaireId { get; set; }
        public string OpenQuestionnaireName { get; set; }
        public DateTime SubmitDate { get; set; }
        public List<Question> Questions { get; set; }
    }
}
