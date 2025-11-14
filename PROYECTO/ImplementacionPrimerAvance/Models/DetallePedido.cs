using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodApp.PrimerAvance.Models;

public class DetallePedido
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid PedidoId { get; set; } // FK
    public Pedido Pedido { get; set; } = null!;
    public Producto Producto { get; set; } = null!;
    public int Cantidad { get; set; }
    public decimal Precio { get; set; }
    public string? Observaciones { get; set; }
    public List<string> OpcionesPersonalizables { get; set; } = new();

    public decimal CalcularSubtotal() => Precio * Cantidad;
}
