namespace EnergyManagementSystem.Models
{
    public class FuelContract : Component
    {
        public int Id { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int Price { get; set; }
        // ... other properties
        // Navigation properties
        public virtual ICollection<FuelContract> FuelConnections { get; set; }
    }
}