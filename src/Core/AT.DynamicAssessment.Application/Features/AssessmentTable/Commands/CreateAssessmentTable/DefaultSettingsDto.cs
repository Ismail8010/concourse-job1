using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AT.DynamicAssessment.Application.Features.AssessmentTable.Commands.CreateAssessmentTable
{
    public class DefaultSettingsDto
    {
        public string? timelimit { get; set; }
        public string? freeNavigation { get; set; }
        public string? canSubmitWithoutAnsweringAll { get; set; }
        public string? canSaveAndExit { get; set; }
        public string? HideViewedQuestions { get; set; }
        public string? attempts { get; set; }
        public string? passingThreashold { get; set; }
        public string? studentReview { get; set; }
    }
}