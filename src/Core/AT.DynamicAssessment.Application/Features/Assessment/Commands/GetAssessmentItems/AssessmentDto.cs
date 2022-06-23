using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AT.DynamicAssessment.Application.Features.Assessment.Commands.GetAssessmentItems;

/// <summary>
///This AssessmentDto use for declare Assessment Property for Respose of API
/// </summary>

public class AssessmentDto
{
    public string? AssessmentId { get; set; }
    public int? AttemptNumber { get; set; }
    public List<ItemDto> Items { get; set; } = new List<ItemDto>();

}

