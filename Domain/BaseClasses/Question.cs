using Domain.Entities.Enums;

namespace Domain.Entities.BaseClasses
{
    public class Question
    {
        public string Id { get; set; }
        public QuestionType Type { get; set; }
        public string QuestionText { get; set; }
        public bool IsOptional { get; set; }
    }
}
