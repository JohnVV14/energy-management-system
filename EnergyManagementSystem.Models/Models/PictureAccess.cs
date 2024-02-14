namespace EnergyManagementSystem.Models
{
    public class PictureAccess
    {
        public int PictureId { get; set; }
        public int UserId { get; set; }

        public virtual ICollection<Picture> Pictures { get; set; }

    }
}