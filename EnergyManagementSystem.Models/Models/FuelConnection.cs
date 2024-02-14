namespace EnergyManagementSystem.Models;

public class FuelConnection
{
    public string fuel { get; set; }
    public int StartCost { get; set; }
    public int StopCost { get; set; }
    public double MaintenanceCostVar { get; set; }
    public double MaintenanceCostFix { get; set; }
    public int AdditionalCost { get; set; }

    public virtual FuelContract FuelContract { get; set; }
    public virtual ProductionUnit ProductionUnit { get; set; }
}