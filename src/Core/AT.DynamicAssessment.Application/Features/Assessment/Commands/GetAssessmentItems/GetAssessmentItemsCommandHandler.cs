using AutoMapper;
using MediatR;
using AT.DynamicAssessment.Application.Contracts.Persistence;


namespace AT.DynamicAssessment.Application.Features.Assessment.Commands.GetAssessmentItems;
/// <summary>
/// This GetAssessmentItemsCommandHandler is use for return response data
/// </summary>

public class GetAssessmentItemsCommandHandler : IRequestHandler<GetAssessmentItemsCommand, GetAssessmentItemsCommandResponse>
{

    private readonly IAssessmentRepository? _assessmentRepository;
    private readonly IMapper? _mapper;
    public GetAssessmentItemsCommandHandler(IMapper mapper)
  {
        _mapper = mapper;
    }
    /// <summary>
    ///  // We are passing request data and CancellationToken and get response
    /// </summary>
   
    public async Task<GetAssessmentItemsCommandResponse> Handle(GetAssessmentItemsCommand request, CancellationToken cancellationToken)
    {
        var response = new GetAssessmentItemsCommandResponse();

        var validator = new GetAssessmentItemsCommandValidator();
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.Errors.Count > 0)
        {
            response.Success = false;
            response.ValidationErrors = new List<string>();
            foreach (var error in validationResult.Errors)
            {
                response.ValidationErrors.Add(error.ErrorMessage);
            }
        }
        if (response.Success)
        {
            AssessmentDto assessmentDto = new AssessmentDto();
            assessmentDto.AssessmentId = "MjI2LDIwMywxMCwxOTEsMjQ0LDE1NywyNTAsNjI=";
            assessmentDto.AttemptNumber = 3;

            List<ItemDto> item = new List<ItemDto>
        {
            new ItemDto { Id = "MTY0LDE0MSwyNTAsNCwyMDksMjE1LDE3MywxNjk=", Version = 123456},
            new ItemDto { Id = "HHY0LDE0MSwyNTAsNCwyMDksMjE1LDE3MywxNjk=", Version = 456543 },
            new ItemDto { Id = "KLY0LDE0MSwyNTAsNCwyMDksMjE1LDE3MywxNjk=", Version = 876567 }
        };

            assessmentDto.Items = item;



            response.Assessment = _mapper?.Map<AssessmentDto>(assessmentDto);

        }
        return response;
    }
}
