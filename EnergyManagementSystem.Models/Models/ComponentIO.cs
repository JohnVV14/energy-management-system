namespace EnergyManagementSystem.Models;

public class ComponentIO
{
    public string Type { get; set; }
    public string Direction { get; set; }
    public string MeasurementUnit { get; set; }
    
    // Navigation properties
    public virtual ICollection<Component> Components { get; set; }
}