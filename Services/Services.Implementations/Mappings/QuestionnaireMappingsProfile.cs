using AutoMapper;
using Domain.Entities;
using Services.Contracts.QuestionnaireDto;

namespace Services.Implementations.Mappings
{
    public class QuestionnaireMappingsProfile : Profile
    {
        public QuestionnaireMappingsProfile()
        {
            CreateMap<CreateQuestionnaireDto, Questionnaire>()
                .ForMember(d => d.Id, map => map.Ignore());
        }
    }
}
