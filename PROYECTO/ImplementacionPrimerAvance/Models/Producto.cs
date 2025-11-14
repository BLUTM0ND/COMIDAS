using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodApp.PrimerAvance.Models;

public class Producto
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid RestauranteId { get; set; } // FK
    public Restaurante Restaurante { get; set; } = null!;
    public string? Nombre { get; set; }
    public string? Descripcion { get; set; }
    public decimal Precio { get; set; }
    public string? Categoria { get; set; }
    public bool Disponible { get; set; } = true;
    public string? Imagen { get; set; }
    public List<string> OpcionesDieteticas { get; set; } = new();

    public void CambiarDisponibilidad(bool disponible) => Disponible = disponible;
}
