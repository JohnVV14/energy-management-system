using MongoDB.Driver;
using EnergyManagementSystem.Models;

namespace EnergyManagementSystem.DataAccess
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database = null;

        public MongoDbContext()
        {
            var client = new MongoClient("mongodb+srv://CarlBedraux:<password>@cluster0.jjcn6vj.mongodb.net/");
            if (client != null)
                _database = client.GetDatabase("TestiTest");
        }

        public IMongoCollection<Component> Components
        {
            get
            {
                return _database.GetCollection<Component>("Component");
            }
        }
    }
}