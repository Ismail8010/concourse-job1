using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AT.DynamicAssessment.Application.Features.AssessmentTable.Commands.CreateAssessmentTable
{
    public class ItemRandamizationDto
    {
        public string? randomization { get; set; }
        public string? keepItemFamiliesTogether { get; set; }
    }
}