using Microsoft.AspNetCore.Mvc;
using EnergyManagementSystem.DataAccess;
using EnergyManagementSystem.Models;
using System.Collections.Generic;

namespace EnergyManagementSystem.Services
{
    [ApiController]
    [Route("[controller]")]
    public class ComponentController : ControllerBase
    {
        private readonly IComponentRepository _repository;

        public ComponentController(IComponentRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Component> GetAll()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public Component GetById(int id)
        {
            return _repository.GetById(id);
        }

        [HttpPost]
        public void Add(Component component)
        {
            _repository.Add(component);
        }

        [HttpPut]
        public void Update(Component component)
        {
            _repository.Update(component);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}