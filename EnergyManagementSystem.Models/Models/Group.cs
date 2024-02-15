namespace EnergyManagementSystem.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }

        public virtual ICollection<Component> Components { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }

    }
}
