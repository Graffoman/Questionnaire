using Domain.Entities.BaseClasses;

namespace Domain.Entities
{
    public class QuestionnaireSubmit
    {
        public string Id { get; set; }
        public User Respondent { get; set; }
        public string OpenQuestionnaireId { get; set; }
        public DateTime SubmitDate { get; set; }
        public List<Question> Questions { get; set; }
    }
}
