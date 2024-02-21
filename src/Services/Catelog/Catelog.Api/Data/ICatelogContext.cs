using Catelog.Api.Entities;
using MongoDB.Driver;

namespace Catelog.Api.Data
{
    public interface ICatelogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
