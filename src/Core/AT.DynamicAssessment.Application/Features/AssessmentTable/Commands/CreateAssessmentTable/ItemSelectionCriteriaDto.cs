using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AT.DynamicAssessment.Application.Features.AssessmentTable.Commands.CreateAssessmentTable
{
    public class ItemSelectionCriteriaDto
    {
        public string numberOfItems { get; set; }
        public string minumunNumberOfItems { get; set; }
        public List<string> selectItemsWithTags { get; set; } = new List<string>();
        public List<string> selectItemsWithTagsFallback { get; set; } = new List<string>();
        public string preferedItemNotseen { get; set; }
        public string preferedSameItemFamily { get; set; }
    }
}