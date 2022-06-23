using Amazon.DynamoDBv2;
using AT.DynamicAssessment.Application.Contracts.Persistence;
using AT.DynamicAssessment.Domian.Entities;

namespace AT.DynamicAssessment.Persistence.Repository;
public class AssessmentTemplateRepository : BaseRepository<AssessmentTemplate>, IAssessmentTemplateRepository
{
    public AssessmentTemplateRepository(IAmazonDynamoDB dynamoDBClient) : base(dynamoDBClient)
    {

    }

    // public async Task<List<Assessment>> GetAssessments()
    // {
    //     List<Assessment> assessments = new List<Assessment>();
    //     return await assessments;
    // }
}