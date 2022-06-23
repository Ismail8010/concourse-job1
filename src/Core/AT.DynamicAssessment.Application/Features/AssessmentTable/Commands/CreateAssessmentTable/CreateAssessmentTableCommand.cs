using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace AT.DynamicAssessment.Application.Features.AssessmentTable.Commands.CreateAssessmentTable
{
    public class CreateAssessmentTableCommand :IRequest<CreateAssessmentTableCommandResponse>
    {
        public AssessmentInfoDto assessmentDto{get; set;}
    }
}