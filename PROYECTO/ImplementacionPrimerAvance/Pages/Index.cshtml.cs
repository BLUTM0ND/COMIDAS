using Microsoft.AspNetCore.Mvc.RazorPages;
using FoodApp.PrimerAvance.Data;
using FoodApp.PrimerAvance.Models;

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

        public void OnGet()
        {
            // Cargar restaurantes desde la base de datos (50% de integración)
            Restaurantes = _context.Restaurantes.ToList();
        }
    }
}