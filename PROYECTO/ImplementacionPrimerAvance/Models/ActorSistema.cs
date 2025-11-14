using System;

namespace FoodApp.PrimerAvance.Models;

public abstract class ActorSistema
{
    // Cambiado a Guid para evitar conflictos y alinear con otras entidades
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    public virtual void ObtenerInformacion() { /* implementable por subclases */ }
}
