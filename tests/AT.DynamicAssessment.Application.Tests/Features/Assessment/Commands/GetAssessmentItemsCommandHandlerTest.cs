using Xunit;
using MediatR;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Shouldly;
using AutoMapper;
using System.Net;
using AT.DynamicAssessment.Application.Features.Assessment.Commands.GetAssessmentItems;
using AT.DynamicAssessment.Application.Profiles;
using System.Threading;
using System.Threading.Tasks;


namespace AT.DynamicAssessment.Application.Tests.Features.Assessment.Commands;

public class GetAssessmentItemsCommandHandlerTest
{
    private readonly IMapper _mapper;
    private readonly GetAssessmentItemsCommand getAssessmentItemsCommand;

    public GetAssessmentItemsCommandHandlerTest()
    {
        var mapperConfig = new MapperConfiguration(c =>
           {
               c.AddProfile<MappingProfile>();
           });
        _mapper = mapperConfig.CreateMapper();

        getAssessmentItemsCommand = new GetAssessmentItemsCommand();

        getAssessmentItemsCommand.AssessmentId = "MjI2LDIwMywxMCwxOTEsMjQ0LDE1NywyNTAsNjI";
        getAssessmentItemsCommand.CtkTakeId = "KliftDIwMywxMCwxOTEsMjQ0LDE1NywyNTAsNjI";
        getAssessmentItemsCommand.AssessmentTemplate = "test";
        List<string> Container = new List<string>();

        Container.Add("container");
        Container.Add("test");
        getAssessmentItemsCommand.AssessmentContainers = Container;
        StudentInformationDto studentInfo = new StudentInformationDto();

        studentInfo.StudentId = "HHY0LDE0MSwyNTAsNCwyMDksMjE1LDE3MywxNjk";
        studentInfo.GradeLevel = "First";

        getAssessmentItemsCommand.StudentInformation = studentInfo;

    }
    /// <summary>
    /// This test case check the input request required parameter is pass null 
    /// and empty then response give the error message, and response status should be false,
    /// check error count greate than 0 and check type of response.
    /// </summary>
    /// <param name="assessmentId"></param>
    /// <param name="ctkTakeId"></param>
    /// <param name="container"></param>
    /// <param name="assessmentTemplate"></param>
    /// <param name="studentId"></param>
    /// <param name="gradeLevel"></param>
    [Theory]
    [ClassData(typeof(GetAssessmentItemsInputInvalideRequest))]
    public async Task Handle_InputRequest_Validation_InvalideTest(string assessmentId,
    string ctkTakeId, List<string> container, string assessmentTemplate, string studentId, string gradeLevel)
    {
        getAssessmentItemsCommand.AssessmentId = assessmentId;
        getAssessmentItemsCommand.CtkTakeId = ctkTakeId;
        getAssessmentItemsCommand.AssessmentContainers = container;
        getAssessmentItemsCommand.AssessmentTemplate = assessmentTemplate;
        getAssessmentItemsCommand.StudentInformation = new StudentInformationDto();
        getAssessmentItemsCommand.StudentInformation.StudentId = studentId;
        getAssessmentItemsCommand.StudentInformation.GradeLevel = gradeLevel;

        var handler = new GetAssessmentItemsCommandHandler(_mapper);
        var response = await handler.Handle(getAssessmentItemsCommand, CancellationToken.None);
        //Assert
        response.ShouldBeOfType<GetAssessmentItemsCommandResponse>();
        response.Success.ShouldBeFalse();
        response.ValidationErrors?.Count.ShouldBeGreaterThan(0);
    }
    /// <summary>
    /// This test case check the input request required parameter is pass 
    /// then response status is true,
    /// check error count equal to 0 and check type of response given.
    /// </summary>
    /// <param name="assessmentId"></param>
    /// <param name="ctkTakeId"></param>
    /// <param name="container"></param>
    /// <param name="assessmentTemplate"></param>
    /// <param name="studentId"></param>
    /// <param name="gradeLevel"></param>
    [Theory]
    [ClassData(typeof(GetAssessmentItemsInputValideRequest))]
    public async Task Handle_InputRequest_Validation_ValideTest(string assessmentId,
    string ctkTakeId, List<string> container, string assessmentTemplate, string studentId, string gradeLevel)
    {
        getAssessmentItemsCommand.AssessmentId = assessmentId;
        getAssessmentItemsCommand.CtkTakeId = ctkTakeId;
        getAssessmentItemsCommand.AssessmentContainers = container;
        getAssessmentItemsCommand.AssessmentTemplate = assessmentTemplate;
        getAssessmentItemsCommand.StudentInformation = new StudentInformationDto();
        getAssessmentItemsCommand.StudentInformation.StudentId = studentId;
        getAssessmentItemsCommand.StudentInformation.GradeLevel = gradeLevel;

        var handler = new GetAssessmentItemsCommandHandler(_mapper);
        var response = await handler.Handle(getAssessmentItemsCommand, CancellationToken.None);
        //Assert
        response.ShouldBeOfType<GetAssessmentItemsCommandResponse>();
        response.Assessment.ShouldNotBeNull();
        response.Success.ShouldBeTrue();
        response.ValidationErrors?.Count.ShouldBe(0);
    }

    /// <summary>
    /// This test case check the input request required parameter is pass 
    /// then response status is true,
    /// check Itams count greater than 0 and check type of response.
    /// </summary>
    /// <param name="assessmentId"></param>
    /// <param name="ctkTakeId"></param>
    /// <param name="container"></param>
    /// <param name="assessmentTemplate"></param>
    /// <param name="studentId"></param>
    /// <param name="gradeLevel"></param>
    [Theory]
    [ClassData(typeof(GetAssessmentItemsInputValideRequest))]
    public async Task Handle_InputRequest_DataValidationTest(string assessmentId,
    string ctkTakeId, List<string> container, string assessmentTemplate, string studentId, string gradeLevel)
    {
        getAssessmentItemsCommand.AssessmentId = assessmentId;
        getAssessmentItemsCommand.CtkTakeId = ctkTakeId;
        getAssessmentItemsCommand.AssessmentContainers = container;
        getAssessmentItemsCommand.AssessmentTemplate = assessmentTemplate;
        getAssessmentItemsCommand.StudentInformation = new StudentInformationDto();
        getAssessmentItemsCommand.StudentInformation.StudentId = studentId;
        getAssessmentItemsCommand.StudentInformation.GradeLevel = gradeLevel;

        var handler = new GetAssessmentItemsCommandHandler(_mapper);
        var response = await handler.Handle(getAssessmentItemsCommand, CancellationToken.None);
        //Assert
        response.ShouldBeOfType<GetAssessmentItemsCommandResponse>();
        response.Success.ShouldBeTrue();
        response.ValidationErrors?.Count.ShouldBe(0);
        response.Assessment?.Items.Count.ShouldBeGreaterThan(0);
    }
    /// <summary>
    /// This test case check the input request required parameter is pass null or empty 
    /// then response status is false,
    /// check Itams count equal to 0 and check ValidationError count.
    /// </summary>
    /// <param name="assessmentId"></param>
    /// <param name="ctkTakeId"></param>
    /// <param name="container"></param>
    /// <param name="assessmentTemplate"></param>
    /// <param name="studentId"></param>
    /// <param name="gradeLevel"></param>
    [Theory]
    [ClassData(typeof(GetAssessmentItemsInputInvalideRequest))]
    public async Task Handle_InputRequest_InvalidDataTest(string assessmentId,
    string ctkTakeId, List<string> container, string assessmentTemplate, string studentId, string gradeLevel)
    {
        getAssessmentItemsCommand.AssessmentId = assessmentId;
        getAssessmentItemsCommand.CtkTakeId = ctkTakeId;
        getAssessmentItemsCommand.AssessmentContainers = container;
        getAssessmentItemsCommand.AssessmentTemplate = assessmentTemplate;
        getAssessmentItemsCommand.StudentInformation = new StudentInformationDto();
        getAssessmentItemsCommand.StudentInformation.StudentId = studentId;
        getAssessmentItemsCommand.StudentInformation.GradeLevel = gradeLevel;

        var handler = new GetAssessmentItemsCommandHandler(_mapper);
        var response = await handler.Handle(getAssessmentItemsCommand, CancellationToken.None);
        //Assert
        response.ValidationErrors?.Count.ShouldBeGreaterThan(0);
        response.Assessment?.Items.Count.ShouldBe(0);
    }
    /// <summary>
    /// This test case check the input request required parameter is pass 
    /// then response status is true,
    /// check type of response, Items, and AssessmentDto.
    /// </summary>
    /// <param name="assessmentId"></param>
    /// <param name="ctkTakeId"></param>
    /// <param name="container"></param>
    /// <param name="assessmentTemplate"></param>
    /// <param name="studentId"></param>
    /// <param name="gradeLevel"></param>
    [Theory]
    [ClassData(typeof(GetAssessmentItemsInputValideRequest))]
    public async Task Handle_InputRequest_CheckTypeTest(string assessmentId,
    string ctkTakeId, List<string> container, string assessmentTemplate, string studentId, string gradeLevel)
    {
        getAssessmentItemsCommand.AssessmentId = assessmentId;
        getAssessmentItemsCommand.CtkTakeId = ctkTakeId;
        getAssessmentItemsCommand.AssessmentContainers = container;
        getAssessmentItemsCommand.AssessmentTemplate = assessmentTemplate;
        getAssessmentItemsCommand.StudentInformation = new StudentInformationDto();
        getAssessmentItemsCommand.StudentInformation.StudentId = studentId;
        getAssessmentItemsCommand.StudentInformation.GradeLevel = gradeLevel;

        var handler = new GetAssessmentItemsCommandHandler(_mapper);
        var response = await handler.Handle(getAssessmentItemsCommand, CancellationToken.None);
        //Assert
        response.ShouldBeOfType<GetAssessmentItemsCommandResponse>();
        response.Assessment?.ShouldBeOfType<AssessmentDto>();
        response.Assessment?.Items.ShouldBeOfType<List<ItemDto>>();
    }

}