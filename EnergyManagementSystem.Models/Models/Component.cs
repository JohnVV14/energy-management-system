﻿namespace EnergyManagementSystem.Models;

public abstract class Component
{

    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string MeasurementUnit { get; set; }

    public virtual ComponentType ComponentType { get; set; }
    public virtual Group? Group { get; set; }
    public virtual Picture? Picture { get; set; }
    public virtual ICollection<Component> Components { get; set; }
    public virtual ICollection<ComponentIO> ComponentIOs { get; set; }

}
