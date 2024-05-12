using Domain.Entities.BaseClasses;

namespace Domain.Entities
{
    public class QuestionSelect : Question
    {
        public new string? Answer { get; set; }
    }
}
