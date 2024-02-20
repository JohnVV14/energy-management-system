using System.Collections.Generic;
using EnergyManagementSystem.Models;

namespace EnergyManagementSystem.Models.TestableUnits
{
    public class TestableComponent : Component
    {
        public TestableComponent()
        {
            // Initialize collections to prevent null reference exceptions during testing
            FuelConnections = new List<FuelContract>();
            ProductionUnits = new List<ProductionUnit>();

            // Set default values for Type and MeasurementUnit
            Type = "DefaultType";
            MeasurementUnit = "DefaultUnit";
        }
    }
}