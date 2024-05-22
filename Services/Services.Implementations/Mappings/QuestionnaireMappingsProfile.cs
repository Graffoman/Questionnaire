using AutoMapper;
using Domain.Entities;
using Domain.Entities.Enums;
using Services.Contracts.QuestionnaireDto;

namespace Services.Implementations.Mappings
{
    public class QuestionnaireMappingsProfile : Profile
    {
        public QuestionnaireMappingsProfile()
        {
            CreateMap<CreateQuestionnaireDto, Questionnaire>()
                .ForMember(x => x.Id, map => map.Ignore())
                .ForMember(x => x.CreationDate, map => map.MapFrom(src => DateTime.Now))
                .ForMember(x => x.LastChangeDate, map => map.MapFrom(src => DateTime.Now))
                .ForMember(x => x.State, map => map.MapFrom(src => QuestionnaireState.ReadyToUse))
                .ForMember(x => x.LastChangedBy, map => map.MapFrom(src => src.Author));

            CreateMap<UpdateQuestionnaireDto, Questionnaire>()
                .ForMember(x => x.Id, map => map.Ignore())
                .ForMember(x => x.LastChangeDate, map => map.MapFrom(src => DateTime.Now));
        }
    }
}
