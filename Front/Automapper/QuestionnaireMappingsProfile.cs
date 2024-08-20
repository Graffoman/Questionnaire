using AutoMapper;
using Domain.Entities;
using Services.Contracts.OpenQuestionnaireDto;
using Services.Contracts.QuestionnaireDto;

namespace Front.Automapper
{
    public class QuestionnaireMappingsProfile : Profile
    {
        public QuestionnaireMappingsProfile()
        {
            CreateMap<Questionnaire, CreateQuestionnaireDto>();

            CreateMap<Questionnaire, UpdateQuestionnaireDto>();

            CreateMap<Questionnaire, CreateOpenQuestionnaireDto>()
                .ForMember(x => x.QuestionnaireRunId, map => map.MapFrom(src => "defaultQuestionnaireRunId"))
                .ForMember(x => x.Respondent, map => map.Ignore())
                .ForMember(x => x.FinalDateToSubmit, map => map.Ignore());
        }
    }
}
