using AutoMapper;
using Domain.Entities;
using Services.Contracts.OpenQuestionnaireDto;

namespace Services.Implementations.Mappings
{
    public class OpenQuestionnaireMappingsProfile : Profile
    {
        public OpenQuestionnaireMappingsProfile()
        {
            CreateMap<CreateOpenQuestionnaireDto, OpenQuestionnaire>()
                .ForMember(x => x.Id, map => map.Ignore())
                .ForMember(x => x.Submitted, map => map.MapFrom(src => false));
        }
    }
}
