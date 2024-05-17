using Domain.Entities.Enums;
using Domain.Entities.BaseClasses;
using Services.Contracts.UserDto;

namespace Services.Contracts.QuestionnaireDto
{
    public class CreateQuestionnaireDto
    {
        public ICollection<Question> Questions { get; set; }
        public GetUserDto Author { get; set; }
        public DateTime CreationDate { get; set; }
        public QuestionnaireState State { get; set; }
        public DateTime LastChangeDate { get; set; }
        public GetUserDto LastChangedBy { get; set; }
    }
}
