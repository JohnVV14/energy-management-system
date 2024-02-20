using EnergyManagementSystem.DataAccess;
using EnergyManagementSystem.Models;
using EnergyManagementSystem.Models.TestableUnits;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Xunit;

namespace EnergyManagementSystem.Tests
{
    public class ComponentRepositoryTest
    {
        [Fact]
        public void GetById_ReturnsComponent()
        {
            // Arrange
            var components = new List<TestableComponent>
            {
                new TestableComponent { Id = 1, Name = "Component 1" },
                new TestableComponent { Id = 2, Name = "Component 2" }
            };

            var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                context.Components.AddRange(components);
                context.SaveChanges();

                var repository = new ComponentRepository(context);

                // Act
                var result = repository.GetById(1);

                // Assert
                Assert.NotNull(result);
                Assert.Equal("Component 1", result.Name);
            }
        }
    }
}