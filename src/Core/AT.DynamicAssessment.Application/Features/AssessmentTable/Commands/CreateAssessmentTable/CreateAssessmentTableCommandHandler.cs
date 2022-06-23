using AT.DynamicAssessment.Application.Contracts.Persistence;
using AutoMapper;
using MediatR;

namespace AT.DynamicAssessment.Application.Features.AssessmentTable.Commands.CreateAssessmentTable
{
    public class CreateAssessmentTableCommandHandler : IRequestHandler<CreateAssessmentTableCommand, CreateAssessmentTableCommandResponse>
    {
        private readonly IAssessmentMockDBRepository _userRepository;
        private readonly IMapper? _mapper;

        public CreateAssessmentTableCommandHandler(IMapper mapper, IAssessmentMockDBRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }


        public async Task<CreateAssessmentTableCommandResponse> Handle(CreateAssessmentTableCommand request, CancellationToken cancellationToken)
        {
            var response = new CreateAssessmentTableCommandResponse();
            AssessmentInfoDto assessmentInfoDto = new AssessmentInfoDto();
            _userRepository.CreateAssessmentTable(request.assessmentDto);
            List<AssessmentInfoDto> assessmentInfoDtos = GetAssessmentData.GetAssessmentInfoStaticValues();
            //request.assessmentDto = AssessmentInfoStaticValues.GetAssessmentInfoStaticValues();
            //_userRepository.AddAssessmentAsync(request.assessmentDto);
            foreach (var item in assessmentInfoDtos)
            {
                _userRepository.AddAssessmentAsync(item);
            }
            response.assessmentDto = _mapper?.Map<AssessmentInfoDto>(assessmentInfoDto);
            return response;
        }


    }
}