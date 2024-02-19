using System.Collections.Generic;
using EnergyManagementSystem.Models;

namespace EnergyManagementSystem.DataAccess
{
    public interface IComponentRepository
    {
        Component GetById(int id);
        IEnumerable<Component> GetAll();
        void Add(Component component);
        void Update(Component component);
        void Delete(int id);
    }
}