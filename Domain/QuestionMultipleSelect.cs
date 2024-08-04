using Domain.Entities.BaseClasses;

namespace Domain.Entities
{
    public class QuestionMultipleSelect : Question
    {
        public List<string>? Options { get; set; }
        public List<string>? Answer { get; set; }
	}
}
