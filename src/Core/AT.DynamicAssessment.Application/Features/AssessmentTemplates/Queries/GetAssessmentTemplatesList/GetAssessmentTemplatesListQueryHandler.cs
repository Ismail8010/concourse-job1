using MediatR;
using AutoMapper;
using AT.DynamicAssessment.Application.Contracts.Persistence;
using AT.DynamicAssessment.Domian.Entities;

namespace AT.DynamicAssessment.Application.Features.AssessmentTamplates.Queries.GetAssessmentTemplateList;
public class GetAssessmentTemplatesListQueryHandler : IRequestHandler<GetAssessmentTemplatesListQuery, List<AssessmentTemplateListVm>>
{
    private readonly IAsyncRepository<AssessmentTemplate> _assessmentTemplateRepository;
    private readonly IMapper _mapper;

    public GetAssessmentTemplatesListQueryHandler(IMapper mapper, IAsyncRepository<AssessmentTemplate> assessmentTemplateRepository)
    {
        _mapper = mapper;
        _assessmentTemplateRepository = assessmentTemplateRepository;
    }

    public async Task<List<AssessmentTemplateListVm>> Handle(GetAssessmentTemplatesListQuery request, CancellationToken cancellationToken)
    {
        var allAssessmentTemplates = (await _assessmentTemplateRepository.ListAllAsync()).OrderBy(x => x.CreatedBy);
        return _mapper.Map<List<AssessmentTemplateListVm>>(allAssessmentTemplates);
    }
}
