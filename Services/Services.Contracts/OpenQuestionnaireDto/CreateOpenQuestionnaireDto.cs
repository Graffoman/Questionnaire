using Domain.Entities.BaseClasses;
using Domain.Entities;

namespace Services.Contracts.OpenQuestionnaireDto
{
    public class CreateOpenQuestionnaireDto
    {
        public User Respondent { get; set; }
        public string QuestionnaireRunId { get; set; }
        public DateTime FinalDateToSubmit { get; set; }
        public List<Question> Questions { get; set; }
    }
}
