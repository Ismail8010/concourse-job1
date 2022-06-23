using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AT.DynamicAssessment.Application.Features.AssessmentTable.Commands.CreateAssessmentTable;
using AT.DynamicAssessment.Application.Model.Event;

namespace AT.DynamicAssessment.Application.Contracts.Persistence
{
    public interface IAssessmentMockDBRepository
    {
        void Create(UserInfo user);
        void CreateAssessmentTable(AssessmentInfoDto assessmentDto);
        void AddAssessmentAsync(AssessmentInfoDto assessmentDto);
    }
}