namespace EnergyManagementSystem.Models
{
    public class ProductionUnit : Component
    {
        public int Id { get; set; }
        public string Type { get; set; }
        // ... other properties
        // Navigation properties
        public virtual Component Component { get; set; }
        // public virtual ICollection<ProductionUnitCost> ProductionUnitCosts { get; set; }
    }


}