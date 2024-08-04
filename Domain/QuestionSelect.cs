using Domain.Entities.BaseClasses;

namespace Domain.Entities
{
    public class QuestionSelect : Question
    {
		public List<string>? Options { get; set; }
		public string? Answer { get; set; }
    }
}
