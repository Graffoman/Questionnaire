using Domain.Entities.BaseClasses;
using Domain.Entities.Enums;

namespace Domain.Entities
{
    public class QuestionMultipleSelect : Question
    {
        public QuestionMultipleSelect()
        {
            Type = QuestionType.MultipleSelect;
            Options = [];
        }
        public List<string> Options { get; set; }
        public List<string>? Answer { get; set; }
	}
}
