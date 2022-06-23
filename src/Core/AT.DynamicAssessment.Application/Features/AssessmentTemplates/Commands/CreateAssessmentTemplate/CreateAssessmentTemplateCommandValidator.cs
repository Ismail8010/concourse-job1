using FluentValidation;

namespace AT.DynamicAssessment.Application.Features.AssessmentTamplates.Commands.CreateAssessmentTemplate;
public class CreateAssessmentTemplateCommandValidator : AbstractValidator<CreateAssessmentTemplateCommand>
{
    public CreateAssessmentTemplateCommandValidator()
    {
        RuleFor(p => p.AssessmentTamplate)
        .NotEmpty().WithMessage("{PropertyName} is required.");
    }
}