using Domain.Entities.BaseClasses;
using Domain.Entities.Enums;

namespace Domain.Entities
{
    public class QuestionIntRange : Question
    {
        public QuestionIntRange() 
        {
            Type = QuestionType.IntRange;
            Limits = new IntRange(10, 100); 
        }
        public IntRange Limits { get; set; }
        public IntRange? Answer { get; set; }
	}
}
