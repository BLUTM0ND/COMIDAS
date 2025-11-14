namespace FoodApp.PrimerAvance.Models;

public class Repartidor : Usuario
{
    public string? Vehiculo { get; set; }
    public string? Licencia { get; set; }
    public string? Zona { get; set; }
    public bool Disponible { get; set; }

    
    public void ActualizarUbicacion(string coordenadas) { /* implementar geoposicion */ }
    public void CompletarEntrega(Pedido pedido) { pedido.ActualizarEstado(EstadoPedido.Entregado); }
}
