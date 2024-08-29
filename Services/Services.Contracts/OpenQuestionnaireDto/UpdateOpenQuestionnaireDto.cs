using Domain.Entities.BaseClasses;
using Domain.Entities;

namespace Services.Contracts.OpenQuestionnaireDto
{
	public class UpdateOpenQuestionnaireDto
	{
		public string Name { get; set; }
		public User Respondent { get; set; }
		public string QuestionnaireRunId { get; set; }
		public DateTime FinalDateToSubmit { get; set; }
		public List<Question> Questions { get; set; }
		public bool Submitted { get; set; }
	}
}
