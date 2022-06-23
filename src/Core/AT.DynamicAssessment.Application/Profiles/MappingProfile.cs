using AT.DynamicAssessment.Application.Features.AssessmentTamplates.Commands.CreateAssessmentTemplate;
using AT.DynamicAssessment.Application.Features.AssessmentTamplates.Queries.GetAssessmentTemplateList;
using AT.DynamicAssessment.Domian.Entities;
using AutoMapper;

namespace AT.DynamicAssessment.Application.Profiles;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<AssessmentTemplate, AssessmentTemplateListVm>().ReverseMap();
        CreateMap<AssessmentTemplate, AssessmentTemplateDto>().ReverseMap();
        CreateMap<AssessmentTemplate, CreateAssessmentTemplateCommand>().ReverseMap();

    }
}