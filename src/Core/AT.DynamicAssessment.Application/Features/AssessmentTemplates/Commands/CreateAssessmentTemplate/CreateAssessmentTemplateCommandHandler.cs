
using AutoMapper;
using MediatR;
using AT.DynamicAssessment.Application.Contracts.Persistence;
using AT.DynamicAssessment.Domian.Entities;

namespace AT.DynamicAssessment.Application.Features.AssessmentTamplates.Commands.CreateAssessmentTemplate;
public class CreateAssessmentTemplateCommandHandler : IRequestHandler<CreateAssessmentTemplateCommand, CreateAssessmentTemplateCommandResponse>
{
    private readonly IAsyncRepository<AssessmentTemplate> _assessmentTemplateRepository;
    private readonly IMapper _mapper;

    public CreateAssessmentTemplateCommandHandler(IMapper mapper, IAsyncRepository<AssessmentTemplate> assessmentTemplateRepository)
    {
        _mapper = mapper;
        _assessmentTemplateRepository = assessmentTemplateRepository;
    }

    public async Task<CreateAssessmentTemplateCommandResponse> Handle(CreateAssessmentTemplateCommand request, CancellationToken cancellationToken)
    {
        var response = new CreateAssessmentTemplateCommandResponse();

        var validator = new CreateAssessmentTemplateCommandValidator();
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.Errors.Count > 0)
        {
            response.Success = false;
            response.ValidationErrors = new List<string>();
            foreach (var error in validationResult.Errors)
            {
                response.ValidationErrors.Add(error.ErrorMessage);
            }
            throw new Exceptions.ValidationException(validationResult);
        }
        if (response.Success)
        {
            // var assessmentTamplate = new AssessmentTemplate()
            // {
            //     Name = request.Name,
            //     Version = request.Version,
            //     Description =request.Description,
            //     AssessmentTamplate = request.AssessmentTamplate
            // };

            var assessmentTemplate = _mapper.Map<AssessmentTemplate>(request);
            assessmentTemplate = await _assessmentTemplateRepository.AddAsync(assessmentTemplate);
            response.AssessmentTemplate = _mapper.Map<AssessmentTemplateDto>(assessmentTemplate);
        }

        return response;

    }
}