using AutoMapper;
using Domain.Entities;
using Services.Contracts.OpenQuestionnaireDto;
using Services.Contracts.QuestionnaireSubmitDto;

namespace Front.Automapper
{
	public class OpenQuestionnaireMappingsProfile : Profile
	{
        public OpenQuestionnaireMappingsProfile()
        {
            CreateMap<OpenQuestionnaire, CreateQuestionnaireSubmitDto>()
                .ForMember(x => x.OpenQuestionnaireId, map => map.MapFrom(src => src.Id));

            CreateMap<OpenQuestionnaire, UpdateQuestionnaireSubmitDto>()
                .ForMember(x => x.OpenQuestionnaireId, map => map.MapFrom(src => src.Id));

            CreateMap<OpenQuestionnaire, UpdateOpenQuestionnaireDto>();
        }
    }
}
