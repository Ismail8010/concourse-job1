using Amazon.DynamoDBv2;
using AT.DynamicAssessment.Application.Contracts.Persistence;

namespace AT.DynamicAssessment.Persistence.Repository;

public class BaseRepository<T> : IAsyncRepository<T> where T : class
{
    protected readonly IAmazonDynamoDB _dynamoDBClient;

    public BaseRepository(IAmazonDynamoDB dynamoDBClient)
    {
        _dynamoDBClient = dynamoDBClient;
    }

    public virtual Task<T> AddAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<T> DeleteAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<IReadOnlyList<T>> ListAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<T> UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }
}