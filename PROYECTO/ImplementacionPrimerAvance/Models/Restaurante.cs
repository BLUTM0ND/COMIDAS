using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodApp.PrimerAvance.Models;

public class Restaurante : ActorSistema
{
    [Key]
    public new Guid Id { get; set; } = Guid.NewGuid();
    public string? NombreComercial { get; set; }
    public string? Ruc { get; set; }
    public string? DireccionTexto { get; set; }
    public int TiempoEntrega { get; set; }
    public double Calificacion { get; set; }
    public EstadoRestaurante Estado { get; set; } = EstadoRestaurante.Abierto;
    public string? UbicacionGPS { get; set; }
    public List<Producto> Menu { get; set; } = new();

    public void ActualizarMenu(Producto producto) { /* agregar/actualizar producto */ }
    public void ProcesarPedido(Pedido pedido) { pedido.ActualizarEstado(EstadoPedido.Preparando); }
}
