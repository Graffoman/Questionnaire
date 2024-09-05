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
                .ForMember(x => x.OpenQuestionnaireId, map => map.MapFrom(src => src.Id))
                .ForMember(x => x.OpenQuestionnaireName, map => map.MapFrom(src => src.Name));

            CreateMap<OpenQuestionnaire, UpdateQuestionnaireSubmitDto>()
                .ForMember(x => x.OpenQuestionnaireId, map => map.MapFrom(src => src.Id))
                .ForMember(x => x.OpenQuestionnaireName, map => map.MapFrom(src => src.Name));

            CreateMap<OpenQuestionnaire, UpdateOpenQuestionnaireDto>();
        }
    }
}
