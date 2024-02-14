namespace EnergyManagementSystem.Models
{
    public class ProductionUnit : Component
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string MeasurementUnit { get; set; }
        public int Auxiliary_power_abs { get; set; }
        public int Auxiliary_power_rel { get; set; }
        public string Auxiliary_from { get; set; }
        public int Max_load_change_speed { get; set; }
        public double Preparation_time_hot { get; set; }
        public double Performancereparation_time_warm { get; set; }
        public double Preparation_time_cold { get; set; }
        public double Cooling_time_hot { get; set; }
        public double Cooling_time_warm { get; set; }
        public string Measure_point { get; set; }
        public bool Start_ramp { get; set; }
        public string Hot_start_ramp { get; set; }
        public string Cold_start_ramp { get; set; }
        public double Load_interval { get; set; }

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

    }


}