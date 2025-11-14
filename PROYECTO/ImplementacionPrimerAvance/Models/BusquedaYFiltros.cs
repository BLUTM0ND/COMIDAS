using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodApp.PrimerAvance.Models;

public class BusquedaYFiltros
{
    public string? TerminoBusqueda { get; set; }
    public Dictionary<string, object> Filtros { get; set; } = new();

    public List<Restaurante> BuscarRestaurantes(IEnumerable<Restaurante> lista)
    {
        // Búsqueda muy simple para la POC - ampliar luego
        return lista.Where(r => string.IsNullOrWhiteSpace(TerminoBusqueda) || (r.NombreComercial?.Contains(TerminoBusqueda, StringComparison.OrdinalIgnoreCase) ?? false)).ToList();
    }
}
