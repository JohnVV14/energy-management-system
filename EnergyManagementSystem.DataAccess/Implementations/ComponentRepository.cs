using Microsoft.EntityFrameworkCore;
using EnergyManagementSystem.DataAccess;
using EnergyManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace EnergyManagementSystem.DataAccess
{
    public class ComponentRepository : IComponentRepository
    {
        private readonly ApplicationDbContext _context;

        public ComponentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Component GetById(int id)
        {
            return _context.Components.Find(id);
        }

        public IEnumerable<Component> GetAll()
        {
            return _context.Components.ToList();
        }

        public void Add(Component component)
        {
            _context.Components.Add(component);
            _context.SaveChanges();
        }

        public void Update(Component component)
        {
            _context.Components.Update(component);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var component = _context.Components.Find(id);
            if (component != null)
            {
                _context.Components.Remove(component);
                _context.SaveChanges();
            }
        }
    }
}