using Domain.Entities.BaseClasses;

namespace Domain.Entities
{
    public class QuestionText : Question
    {
        public new string? Answer { get; set; }
    }
}
