using AutoMapper;
using Domain.Entities;
using Services.Contracts.QuestionnaireDto;

namespace Front.Automapper
{
    public class QuestionnaireMappingsProfile : Profile
    {
        public QuestionnaireMappingsProfile()
        {
            CreateMap<Questionnaire, CreateQuestionnaireDto>();

            CreateMap<Questionnaire, UpdateQuestionnaireDto>();
		}
    }
}
