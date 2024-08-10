using Domain.Entities.Enums;

namespace Domain.Entities.BaseClasses
{
    public class Question
    {
        public string Id { get; } = Guid.NewGuid().ToString();
        public QuestionType Type { get; set; }
        public string QuestionText { get; set; } = "Введите текст вопроса";
        public bool IsOptional { get; set; } = false;
    }
}
