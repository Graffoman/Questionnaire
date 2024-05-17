using Domain.Entities.BaseClasses;

namespace Domain.Entities
{
    public class QuestionIntRange : Question
    {
        public IntRange? Answer { get; set; }
    }
}
