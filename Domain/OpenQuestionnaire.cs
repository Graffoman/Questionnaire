using Domain.Entities.BaseClasses;

namespace Domain.Entities
{
    public class OpenQuestionnaire
    {
        public string Id { get; set; }
        public User Respondent { get; set; }
        public string QuestionnaireRunId { get; set; }
        public DateTime FinalDateToSubmit { get; set; }
        public List<Question> Questions { get; set; }
        public bool Submitted { get; set; } = false;
    }
}
