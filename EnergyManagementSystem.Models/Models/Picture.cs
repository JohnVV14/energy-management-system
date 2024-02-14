namespace EnergyManagementSystem.Models
{
    public class Picture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // Assuming there's a byte array to hold the picture data
        public byte[] Data { get; set; }
    }
}