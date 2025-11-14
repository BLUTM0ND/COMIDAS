using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace FoodApp.PrimerAvance.Models;

public class Pedido
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime FechaPedido { get; set; } = DateTime.UtcNow;
    public EstadoPedido Estado { get; set; } = EstadoPedido.Pendiente;
    public decimal Total { get; set; }
    public int TiempoEstimado { get; set; }
    public TipoPago MetodoPago { get; set; }
    public decimal Propina { get; set; }
    public decimal Descuento { get; set; }
    public List<DetallePedido> Detalles { get; set; } = new();
    public Direccion? DireccionEntrega { get; set; }
    public Pago? Pago { get; set; }
    public decimal CalcularTotal()
    {
        var subtotal = Detalles.Sum(d => d.CalcularSubtotal());
        Total = subtotal + Propina - Descuento;
        return Total;
    }
    public void ActualizarEstado(EstadoPedido nuevo)
    {
        Estado = nuevo;
    }
    public EstadoPedido RastrearPedido() => Estado;
}
