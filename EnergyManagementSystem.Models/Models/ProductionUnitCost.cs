namespace EnergyManagementSystem.Models;

public class ProductionUnitCost
{
    public int StartCostHot { get; set; }
    public int StartCostWarm { get; set; }
    public int StartCostCold { get; set; }
    public int LoadChangeCost { get; set; }
    public double MaintenanceCostVar { get; set; }
    public double MaintenanceCostFix { get; set; }

    public virtual ProductionUnit ProductionUnit { get; set; }
}
