namespace EnergyManagementSystem.Models
{
    public class Sink : Component
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string MeasurementUnit { get; set; }
        public int Price { get; set; }

public Dictionary<string, int> Power { get; set; }

    public Sink()
    {
        Power = new Dictionary<string, int>();
    }

    public void AddPower(string type, int value)
    {
        Power[type] = value;
    }
    
    }
 
    }
