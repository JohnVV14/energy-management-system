namespace EnergyManagementSystem.Models
{
    public class ProductionUnit : Component
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string MeasurementUnit { get; set; }
        public int AuxiliaryPowerAbs { get; set; }
        public int AuxiliaryPowerRel { get; set; }
        public string AuxiliaryFrom { get; set; }
        public int MaxLoadChangeSpeed { get; set; }
        public double PreparationTimeHot { get; set; }
        public double PerformancereparationTimeWarm { get; set; }
        public double PreparationTimeCold { get; set; }
        public double CoolingTimeHot { get; set; }
        public double CoolingTimeWarm { get; set; }
        public string MeasurePoint { get; set; }
        public bool StartRamp { get; set; }
        public string HotStartRamp { get; set; }
        public string ColdStartRamp { get; set; }
        public double LoadInterval { get; set; }

            // Dictionary to represent performance with different types
    public Dictionary<string, int> Performance { get; set; }

    public ProductionUnit()
    {
        Performance = new Dictionary<string, int>();
    }

    // Method to add performance value
    public void AddPerformance(string type, int value)
    {
        Performance[type] = value;
    }

     public virtual ICollection<FuelContract> FuelConnections { get; set; }

    }


}