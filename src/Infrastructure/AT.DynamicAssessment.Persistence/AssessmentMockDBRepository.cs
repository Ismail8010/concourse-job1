using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.Model;
using AT.DynamicAssessment.Application.Contracts.Persistence;
using AT.DynamicAssessment.Application.Features.AssessmentTable.Commands.CreateAssessmentTable;
using AT.DynamicAssessment.Application.Model.Event;
using Model = AT.DynamicAssessment.Application.Model;

namespace AT.DynamicAssessment.Persistence;


public class AssessmentMockDBRepository : IAssessmentMockDBRepository
{
    private readonly IAmazonDynamoDB _dynamoDBClient;
    private readonly DynamoDBContext _context;

    public AssessmentMockDBRepository(IAmazonDynamoDB dynamoDBClient)
    {
        _dynamoDBClient = dynamoDBClient;
        _context = new DynamoDBContext(dynamoDBClient);
    }

    public async void AddAssessmentAsync(AssessmentInfoDto assessmentDto)
    {
         await _context.SaveAsync(assessmentDto);
    }

    public async void Create(UserInfo user)
    {
        try
        {
            var request = new PutItemRequest
            {
                TableName = "user-table",
                Item = new Dictionary<string, AttributeValue>
            {
                {"Id", new AttributeValue(user.Id)},
                {"Name", new AttributeValue(user.Name)},
                {"City", new AttributeValue(user.City)},

            }
            };
            var response = await _dynamoDBClient.PutItemAsync(request);
        }
        catch (Exception ex)
        {
            var msg = ex.Message;
        }




    }

    public void CreateAssessmentTable(AssessmentInfoDto assessmentDto)
    {
        try
        {
            string tableName = "Dynamic-Assessment";
            // Attribute definitions
            var attributeDefinitions = new List<AttributeDefinition>()
        {
            {new AttributeDefinition {
                 AttributeName = "partition_key", AttributeType = "S"
             }},
            {new AttributeDefinition {
                 AttributeName = "sort_key", AttributeType = "S"
             }},

        };

            // Key schema for table
            var tableKeySchema = new List<KeySchemaElement>()
            {
            {
                new KeySchemaElement {
                    AttributeName= "partition_key",
                    KeyType = "HASH" //Partition key
                }
            },
            {
                new KeySchemaElement {
                    AttributeName = "sort_key",
                    KeyType = "RANGE" //Sort key
                }
            }
            };

            //Create table request
            var createTableRequest = new CreateTableRequest
            {
                TableName = tableName,
                ProvisionedThroughput = new ProvisionedThroughput
                {
                    ReadCapacityUnits = 10,
                    WriteCapacityUnits = 5
                },
                AttributeDefinitions = attributeDefinitions,
                KeySchema = tableKeySchema,
            };

            var response = _dynamoDBClient.CreateTableAsync(createTableRequest);
        }
        catch (Exception ex)
        {
            var msg = ex.Message;
        }

    }
}

// public class UserInfo
// {
//     public string? Id { get; set; }
//     public string? Name { get; set; }
//     public string? City { get; set; }

// }