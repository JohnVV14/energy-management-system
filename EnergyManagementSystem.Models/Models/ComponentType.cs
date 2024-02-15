namespace EnergyManagementSystem.Models;

public class ComponentType
{
    public string Name { get; set; }
    public string Image { get; set; }
    public string BasedOn{ get; set; }
    
    public virtual ICollection<Component> Components { get; set; }
}