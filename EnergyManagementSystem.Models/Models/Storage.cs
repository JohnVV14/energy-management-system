namespace EnergyManagementSystem.Models
{
    public class Storage : Component
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string MeasurementUnit { get; set; }
        public int StartCost { get; set; }
        public int StopCost { get; set; }
        public int AuxiliaryPowerRel { get; set; }
        public string AuxiliaryPowerFrom { get; set; }

public Dictionary<string, int> DischargeCapacity { get; set; }

    public void AddDischargeCapacity(string type, int value)
    {
        DischargeCapacity[type] = value;
    }

    public Dictionary<string, int> ChargeCapacity { get; set; }

    public void AddChargeCapacity(string type, int value)
    {
        ChargeCapacity[type] = value;
    }

    public Dictionary<string, int> ContentCapacity { get; set; }

        public void AddContentCapacity(string type, int value)
    {
        ContentCapacity[type] = value;
    }

    public Storage()
    {
        ContentCapacity = new Dictionary<string, int>();
        DischargeCapacity = new Dictionary<string, int>();
        ContentCapacity = new Dictionary<string, int>();
    }


    }
}