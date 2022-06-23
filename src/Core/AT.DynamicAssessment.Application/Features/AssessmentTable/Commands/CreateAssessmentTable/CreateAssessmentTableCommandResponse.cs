using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AT.DynamicAssessment.Application.Responses;

namespace AT.DynamicAssessment.Application.Features.AssessmentTable.Commands.CreateAssessmentTable
{
    public class CreateAssessmentTableCommandResponse : BaseResponse
    {
        public CreateAssessmentTableCommandResponse() : base()
        {
            
        }
        public AssessmentInfoDto? assessmentDto{get; set;}
    }
}