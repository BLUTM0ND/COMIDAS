using Microsoft.AspNetCore.Mvc.RazorPages;
using FoodApp.PrimerAvance.Data;
using FoodApp.PrimerAvance.Models;
using System.Text.Json;

namespace FoodApp.PrimerAvance.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Restaurante> Restaurantes { get; set; } = new();
        public string ProductosJson { get; set; } = "{}";

        public void OnGet()
        {
            // Cargar restaurantes desde la base de datos
            Restaurantes = _context.Restaurantes.ToList();

            // Cargar productos desde la base de datos y agrupar por restaurante
            var productosPorRestaurante = _context.Productos
                .GroupBy(p => p.RestauranteId)
                .ToDictionary(g => g.Key.ToString(), g => g.Select(p => new
                {
                    id = p.Id,
                    nombre = p.Nombre,
                    descripcion = p.Descripcion,
                    precio = p.Precio,
                    categoria = p.Categoria,
                    disponible = p.Disponible,
                    opcionesDieteticas = p.OpcionesDieteticas
                }).ToList());

            ProductosJson = JsonSerializer.Serialize(productosPorRestaurante);
        }
    }
}