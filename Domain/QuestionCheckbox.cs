using Domain.Entities.BaseClasses;
using Domain.Entities.Enums;

namespace Domain.Entities
{
    public class QuestionCheckbox : Question
    {
		public QuestionCheckbox()
		{
			Type = QuestionType.Checkbox;
		}
		public bool Answer { get; set; }
    }
}
