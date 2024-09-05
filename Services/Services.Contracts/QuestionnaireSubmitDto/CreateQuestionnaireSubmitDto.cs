using Domain.Entities.BaseClasses;
using Domain.Entities;

namespace Services.Contracts.QuestionnaireSubmitDto
{
    public class CreateQuestionnaireSubmitDto
    {
        public User Respondent { get; set; }
        public string OpenQuestionnaireId { get; set; }
        public string OpenQuestionnaireName { get; set; }
        public List<Question> Questions { get; set; }
    }
}
