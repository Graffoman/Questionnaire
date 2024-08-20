using AutoMapper;
using Domain.Entities;
using Services.Contracts.QuestionnaireSubmit;

namespace Services.Implementations.Mappings
{
    public class QuestionnaireSubmitMappingsProfile : Profile
    {
        public QuestionnaireSubmitMappingsProfile()
        {
            CreateMap<CreateQuestionnaireSubmitDto, QuestionnaireSubmit>()
                .ForMember(x => x.Id, map => map.Ignore())
                .ForMember(x => x.SubmitDate, map => map.MapFrom(src => DateTime.Now));

            CreateMap<UpdateQuestionnaireSubmitDto, QuestionnaireSubmit>()
                .ForMember(x => x.Id, map => map.Ignore())
                .ForMember(x => x.SubmitDate, map => map.MapFrom(src => DateTime.Now));
        }
    }
}
