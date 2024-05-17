using Domain.Entities.BaseClasses;

namespace Domain.Entities
{
    public class QuestionMultipleSelect : Question
    {
        public List<string>? Answer { get; set; }
    }
}
