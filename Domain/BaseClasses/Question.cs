using Domain.Entities.Enums;

namespace Domain.Entities.BaseClasses
{
    public class Question
    {
        public Guid Id { get; set; }
        public QuestionType Type { get; set; }
        public string QuestionText { get; set; }
        public bool IsOptional { get; set; }
        public object? Answer { get; set; }
    }
}
