using Domain.Entities.BaseClasses;
using Domain.Entities.Enums;

namespace Domain.Entities
{
    public class QuestionSelect : Question
    {
        public QuestionSelect()
        {
            Type = QuestionType.Select;
            Options = [];
        }
        public List<string> Options { get; set; }
		public string? Answer { get; set; }
    }
}
