using Test.Models;

namespace Services
{
    public class BooksRepository : BaseMongoRepository<Books>
    {
        public BooksRepository(string mongoDBConnectionString, string dbName, string collectionName) : base(mongoDBConnectionString, dbName, collectionName)            
        {            
        }
    }
}