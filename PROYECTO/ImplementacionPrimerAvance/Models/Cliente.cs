using System;
using System.Collections.Generic;

namespace FoodApp.PrimerAvance.Models;

public class Cliente : Usuario
{
    public List<Direccion> Direcciones { get; set; } = new();
    public List<Pedido> HistorialPedidos { get; set; } = new();

    public void AgregarDireccion(Direccion d) => Direcciones.Add(d);
    public Pedido? RealizarPedido(Pedido pedido)
    {
        // Validaciones básicas - implementación completa en próxima iteración
        HistorialPedidos.Add(pedido);
        return pedido;
    }
}
