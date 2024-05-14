using Domain.Entities.Enums;

namespace Services.Contracts.QuestionDto
{
    public class CreateQuestionDto
    {
        public QuestionType Type { get; set; }
        public string QuestionText { get; set; }
        public bool IsOptional { get; set; }
        public object? Answer { get; set; }
    }
}
