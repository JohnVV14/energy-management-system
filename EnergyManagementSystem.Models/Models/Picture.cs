namespace EnergyManagementSystem.Models
{
    public class Picture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Grid { get; set; }

        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Component> Components { get; set; }
        public virtual ICollection<PictureAccess> PictureAccess { get; set; }
    }
}