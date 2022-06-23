
//using System;
using AutoMapper;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using AT.DynamicAssessment.Application.Contracts.Persistence;
using AT.DynamicAssessment.Application.Features.AssessmentTamplates.Commands.CreateAssessmentTemplate;
using AT.DynamicAssessment.Application.Profiles;
using AT.DynamicAssessment.Domian.Entities;
using AT.DynamicAssessment.Application.Tests.Mocks;


namespace AT.DynamicAssessment.Application.Tests.Features.AssessmentTemplates.Commands;

public class CreateAssessmentTemplateTests //: IDisposable
{
    private readonly IMapper _mapper;
    private readonly ITestOutputHelper _output;
    private readonly Mock<IAsyncRepository<AssessmentTemplate>> _mockAssessmentTemplateRepository;

    /// <summary>
    /// Constructor to instantiate  common objects 
    /// </summary>
    /// <param name="output">object used to add extra text on Test case output</param>
    public CreateAssessmentTemplateTests(ITestOutputHelper output)
    {
        _mockAssessmentTemplateRepository = RepositoryMocks.GetAssessmentTemplateRepository();
        var configurationProvider = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<MappingProfile>();
        });

        _mapper = configurationProvider.CreateMapper();
        _output = output;
    }

    //To dispose objects after executing all the test cases in this file.
    // public void Dispose()
    // {
    //     throw new NotImplementedException();
    // }

    [Fact]
    public async Task Handle_validAssessmentTemplate_AddedToAssessmentTemplateRepo()
    {
        //Assign
        var handler = new CreateAssessmentTemplateCommandHandler(_mapper, _mockAssessmentTemplateRepository.Object);

        await handler.Handle(new CreateAssessmentTemplateCommand() { AssessmentTamplate = "Test", Name = "Test", Version = 2 }, CancellationToken.None);

        //Act
        var allAssessmentTemplates = await _mockAssessmentTemplateRepository.Object.ListAllAsync();

        //Assert
        allAssessmentTemplates.Count.ShouldBe(5);
    }

}