using Xunit;
using System.Collections.Generic;
using Shouldly;
using System.Net;
using AT.DynamicAssessment.Application.Features.Assessment.Commands.GetAssessmentItems;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Newtonsoft.Json;
using AT.DynamicAssessment.IntegrationTests.ControllerTests;

namespace AT.DynamicAssessment.api.tests.ControllerTests;
/// <summary>
/// Text cases for Assessment controller end points
/// </summary>
public class AssessmentControllerTests : IClassFixture<ApiWebApplicationFactory>
{
    private readonly GetAssessmentItemsCommand getAssessmentItemsCommandMockData;
    /// <summary>
    /// Constructor
    /// </summary>
    public AssessmentControllerTests()
    {

        getAssessmentItemsCommandMockData = GetAssessmentItemsCommandData();
    }

    /// <summary>
    /// Unit test case for valid or return Success response from Assessment Controller
    /// </summary>
    /// <returns></returns>
    [Fact]
    public async Task ReturnsSuccessResult()
    {
        var api = new ApiWebApplicationFactory();
        //Act
        var jsonResponse = await api.CreateClient().PostAsJsonAsync(Constants.AssessmentUrl, getAssessmentItemsCommandMockData);
        var response = JsonConvert.DeserializeObject<GetAssessmentItemsCommandResponse>(
         await jsonResponse.Content.ReadAsStringAsync()
        );
        //Assert
        response.ValidationErrors?.Count.ShouldBe(0);
        jsonResponse.IsSuccessStatusCode.ShouldBeTrue();
        response.Success.ShouldBe(true);

    }

    /// <summary>
    /// Unit test case for valid or return response type from Assessment Controller
    /// </summary>
    /// <returns></returns>
    [Fact]
    public async Task ReturnsSuccessResult_CheckResponseTypes()
    {
        var api = new ApiWebApplicationFactory();
        //Act
        var jsonResponse = await api.CreateClient().PostAsJsonAsync(Constants.AssessmentUrl, getAssessmentItemsCommandMockData);
        var response = JsonConvert.DeserializeObject<GetAssessmentItemsCommandResponse>(
          await jsonResponse.Content.ReadAsStringAsync()
        );
        //Assert
        response.ShouldBeOfType<GetAssessmentItemsCommandResponse>();
        response.Assessment.ShouldBeOfType<AssessmentDto>();
        response.Assessment?.Items.ShouldBeOfType<List<ItemDto>>();
    }

    /// <summary>
    /// Unit test case for valid or return not null from Assessment Controller
    /// </summary>
    /// <param name="assessmentId"></param>
    /// <param name="ctkTakeId"></param>
    /// <param name="container"></param>
    /// <param name="assessmentTemplate"></param>
    /// <param name="studentId"></param>
    /// <param name="gradeLevel"></param>
    [Theory, ClassData(typeof(GetAssessmentTestNullData))]
    public async Task ReturnsSuccessResult_CheckNullResponse(string assessmentId, string ctkTakeId, List<string> container, string assessmentTemplate, string studentId, string gradeLevel)
    {
        var api = new ApiWebApplicationFactory();
        //Assign
        getAssessmentItemsCommandMockData.AssessmentId = assessmentId;
        getAssessmentItemsCommandMockData.CtkTakeId = ctkTakeId;
        getAssessmentItemsCommandMockData.AssessmentContainers = container;
        getAssessmentItemsCommandMockData.AssessmentTemplate = assessmentTemplate;

        StudentInformationDto studentInfo = new StudentInformationDto();
        studentInfo.StudentId = studentId;
        studentInfo.GradeLevel = gradeLevel;
        getAssessmentItemsCommandMockData.StudentInformation = studentInfo;
        //Act
        var jsonResponse = await api.CreateClient().PostAsJsonAsync(Constants.AssessmentUrl, getAssessmentItemsCommandMockData);
        var response = JsonConvert.DeserializeObject<GetAssessmentItemsCommandResponse>(
          await jsonResponse.Content.ReadAsStringAsync()
        );
        //Assert
        response.ShouldNotBeNull();
        if (response.Success)
        {
            response.Message.ShouldBeNull();
            response.ValidationErrors.ShouldBeNull();
        }
        else
        {
            response.Assessment.ShouldBeNull();
        }
    }
    /// <summary>
    /// Unite test case for return Bad request from controller
    /// </summary>
    /// <param name="assessmentId"></param>
    /// <param name="ctkTakeId"></param>
    /// <param name="container"></param>
    /// <param name="assessmentTemplate"></param>
    /// <param name="studentId"></param>
    /// <param name="gradeLevel"></param>
    /// <returns></returns>
    [Theory, ClassData(typeof(GetAssessmentTestInvalidData))]
    public async Task ReturnBadRequestResult_WithValidationErrors(string assessmentId, string ctkTakeId, List<string> container, string assessmentTemplate, string studentId, string gradeLevel)
    {
        //Assign
        var api = new ApiWebApplicationFactory();
        getAssessmentItemsCommandMockData.AssessmentId = assessmentId;
        getAssessmentItemsCommandMockData.CtkTakeId = ctkTakeId;
        getAssessmentItemsCommandMockData.AssessmentContainers = container;
        getAssessmentItemsCommandMockData.AssessmentTemplate = assessmentTemplate;

        StudentInformationDto studentInfo = new StudentInformationDto();
        studentInfo.StudentId = studentId;
        studentInfo.GradeLevel = gradeLevel;
        getAssessmentItemsCommandMockData.StudentInformation = studentInfo;
        //Act
        var jsonResponse = await api.CreateClient().PostAsJsonAsync(Constants.AssessmentUrl, getAssessmentItemsCommandMockData);
        var response = JsonConvert.DeserializeObject<GetAssessmentItemsCommandResponse>(
          await jsonResponse.Content.ReadAsStringAsync()
        );
        //Assert
        response.ShouldNotBeNull();
        response.ValidationErrors.ShouldNotBeNull();
        response.ValidationErrors?.Count.ShouldBeGreaterThan(0);

    }

    /// <summary>
    /// Mock data for Assessment unit testing
    /// </summary>
    /// <returns></returns>
    private GetAssessmentItemsCommand GetAssessmentItemsCommandData()
    {
        GetAssessmentItemsCommand getAssessmentItemsCommand = new GetAssessmentItemsCommand();

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

        DeliveryConfigurationDto deliveryConfiguration = new DeliveryConfigurationDto();
        deliveryConfiguration.Attempt = 5;
        deliveryConfiguration.PassingThreashold = 70;
        deliveryConfiguration.TimeLimit = 60;
        deliveryConfiguration.StudentReview = "NoReview/QuestionAndStudentAnswers/QuestionsAndCorrectAnswers";
        deliveryConfiguration.SaveAndExit = "on";
        deliveryConfiguration.HideViewedQuestions = "yes";
        getAssessmentItemsCommand.DeliveryConfiguration = deliveryConfiguration;


        ExtensionsDto extensions = new ExtensionsDto();
        extensions.EnrollmentId = "";
        extensions.CourseId = "";
        extensions.SectionId = "JOY0LDE0MSwyNTAsNCwyMDksMjE1LDE3MywxNjk";

        ProductInformationDto productInformation = new ProductInformationDto();
        productInformation.Extensions = extensions;
        productInformation.Product = "";
        getAssessmentItemsCommand.ProductInformation = productInformation;
        return getAssessmentItemsCommand;
    }

}
