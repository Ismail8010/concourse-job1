using AT.DynamicAssessment.Application.Contracts.Persistence;
using AT.DynamicAssessment.Domian.Entities;
using Moq;
using System;
using System.Collections.Generic;

namespace AT.DynamicAssessment.Application.Tests.Mocks
{
    public class RepositoryMocks
    {
        public static Mock<IAsyncRepository<AssessmentTemplate>> GetAssessmentTemplateRepository()
        {
            //var id = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76A7C5DDE}");

            var assessmentTemplates = new List<AssessmentTemplate>
            {
                new AssessmentTemplate
                {
                   AssessmentTamplate = "",
                   Name = "",
                   Version= 1,
                },
                new AssessmentTemplate
                {
                   AssessmentTamplate = "",
                   Name = "",
                   Version= 1,
                },
               new AssessmentTemplate
                {
                   AssessmentTamplate = "",
                   Name = "",
                   Version= 1,
                },
                new AssessmentTemplate
                {
                   AssessmentTamplate = "",
                   Name = "",
                   Version= 1,
                },
            };

            var mockAssessmentTemplateRepository = new Mock<IAsyncRepository<AssessmentTemplate>>();
            mockAssessmentTemplateRepository.Setup(repo => repo.ListAllAsync()).ReturnsAsync(assessmentTemplates);

            mockAssessmentTemplateRepository.Setup(repo => repo.AddAsync(It.IsAny<AssessmentTemplate>())).ReturnsAsync(
                (AssessmentTemplate assessmentTemplate) =>
                {
                    assessmentTemplates.Add(assessmentTemplate);
                    return assessmentTemplate;
                });

            return mockAssessmentTemplateRepository;
        }
    }
}
