using MongoDB.Driver;
using EnergyManagementSystem.DataAccess;
using EnergyManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace EnergyManagementSystem.DataAccess
{
    public class ComponentRepository : IComponentRepository
    {
        private readonly MongoDbContext _context;

        public ComponentRepository(MongoDbContext context)
        {
            _context = context;
        }

        public Component GetById(int id)
        {
            return _context.Components.Find(c => c.Id == id).FirstOrDefault();
        }

        public IEnumerable<Component> GetAll()
        {
            return _context.Components.Find(_ => true).ToList();
        }

        public void Add(Component component)
        {
            _context.Components.InsertOne(component);
        }

        public void Update(Component component)
        {
            _context.Components.ReplaceOne(c => c.Id == component.Id, component);
        }

        public void Delete(int id)
        {
            _context.Components.DeleteOne(c => c.Id == id);
        }
    }
}