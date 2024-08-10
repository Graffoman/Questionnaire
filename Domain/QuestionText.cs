using Domain.Entities.BaseClasses;
using Domain.Entities.Enums;

namespace Domain.Entities
{
    public class QuestionText : Question
    {
        public QuestionText()
        {
            Type = QuestionType.Text;
        }
        public string? Answer { get; set; }
    }
}
