using Domain.Entities.BaseClasses;

namespace Domain.Entities
{
    public class QuestionCheckbox : Question
    {
        public new bool? Answer { get; set; }
    }
}
