namespace EnergyManagementSystem.Models;

public class ComponentType
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }
    // Navigation properties
    public virtual ICollection<Component> Components { get; set; }
}