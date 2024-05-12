using Domain.Entities.BaseClasses;

namespace Domain.Entities
{
    public class QuestionMultipleSelect : Question
    {
        public new List<string>? Answer { get; set; }
    }
}
