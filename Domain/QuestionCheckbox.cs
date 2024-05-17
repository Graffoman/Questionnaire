using Domain.Entities.BaseClasses;

namespace Domain.Entities
{
    public class QuestionCheckbox : Question
    {
        public bool? Answer { get; set; }
    }
}
