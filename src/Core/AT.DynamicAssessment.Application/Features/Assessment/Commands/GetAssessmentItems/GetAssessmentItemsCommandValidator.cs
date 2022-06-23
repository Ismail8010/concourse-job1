using FluentValidation;

namespace AT.DynamicAssessment.Application.Features.Assessment.Commands.GetAssessmentItems;
/// <summary>
///This GetAssessmentItemsCommandValidator use for validation
/// </summary>

public class GetAssessmentItemsCommandValidator : AbstractValidator<GetAssessmentItemsCommand>
{
    public GetAssessmentItemsCommandValidator()
    {
        RuleFor(p => p.AssessmentId)
    .NotEmpty().WithMessage("{PropertyName} is required.");

    RuleFor(p => p.CtkTakeId)
    .NotEmpty().WithMessage("{PropertyName} is required.");

    RuleFor(p => p.StudentInformation.StudentId)
    .NotEmpty().WithMessage("{PropertyName} is required.");

    RuleFor(p => p.StudentInformation.GradeLevel)
    .NotEmpty().WithMessage("{PropertyName} is required.");

    RuleFor(p => p.AssessmentTemplate)
    .NotEmpty().WithMessage("{PropertyName} is required.");
    

    RuleFor(p => p.AssessmentContainers)
    .NotEmpty().WithMessage("{PropertyName} is required.");
    }

}
