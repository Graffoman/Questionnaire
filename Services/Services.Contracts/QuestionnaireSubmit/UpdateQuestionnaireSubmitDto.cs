using Domain.Entities.BaseClasses;
using Domain.Entities;

namespace Services.Contracts.QuestionnaireSubmit
{
    public class UpdateQuestionnaireSubmitDto
    {
        public User Respondent { get; set; }
        public string OpenQuestionnaireId { get; set; }
        public List<Question> Questions { get; set; }
    }
}
