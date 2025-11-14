using System;

namespace FoodApp.PrimerAvance.Models;

public class Pago
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public decimal Monto { get; set; }
    public DateTime Fecha { get; set; } = DateTime.UtcNow;
    public EstadoPago Estado { get; set; } = EstadoPago.Pendiente;
    public string? TipoTarjeta { get; set; }
    public string? DatosEncriptados { get; set; }

    public bool ProcesarPago() { /* integración con IServicioPagos en futuras iteraciones */ return false; }
    public void ConfirmarPago() { Estado = EstadoPago.Completado; }
}
