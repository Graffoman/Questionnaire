using Domain.Entities.BaseClasses;

namespace Domain.Entities
{
    public class QuestionIntRange : Question
    {
        public int? From { get; set; }
        public int? To { get; set; }
    }
}
