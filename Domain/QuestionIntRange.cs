using Domain.Entities.BaseClasses;

namespace Domain.Entities
{
    public class QuestionIntRange : Question
    {
        public IntRange? Limits { get; set; }
        public IntRange? Answer { get; set; }
	}
}
