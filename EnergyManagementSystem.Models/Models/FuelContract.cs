namespace EnergyManagementSystem.Models
{
    public class FuelContract : Component
    {
        public int Id { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int Price { get; set; }
        public double PriceCo2 { get; set;}
        public double MaxLimitCost { get; set;}
        public int Repeat { get; set; }
        public int UsedAmount { get; set; }
        public string MeasurementPointForUsedAmount { get; set; }
        public float Co2EuAllowence
        public string Fuel { get; set; }

public Dictionary<string, int> Amount { get; set; }

    public Fuel()
    {
        Amount = new Dictionary<string, int>();
    }

    // Method to add performance value
    public void AddAmount(string type, int value)
    {
        Amount[type] = value;
    }
        public virtual ICollection<FuelContract> FuelConnections { get; set; }
    }
}