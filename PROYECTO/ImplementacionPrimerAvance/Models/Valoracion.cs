using System;

namespace FoodApp.PrimerAvance.Models;

public class Valoracion
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public int CalificacionRestaurante { get; set; }
    public int CalificacionPedido { get; set; }
    public string? Comentario { get; set; }
    public DateTime FechaValoracion { get; set; } = DateTime.UtcNow;

    public void GuardarValoracion() { /* persistir - implementación futura */ }
}
