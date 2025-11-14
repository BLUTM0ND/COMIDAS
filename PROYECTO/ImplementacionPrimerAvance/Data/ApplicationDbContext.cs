using Microsoft.EntityFrameworkCore;
using FoodApp.PrimerAvance.Models;

namespace FoodApp.PrimerAvance.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Restaurante> Restaurantes { get; set; }
    public DbSet<Producto> Productos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Repartidor> Repartidores { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }
    public DbSet<DetallePedido> DetallesPedido { get; set; }
    public DbSet<Direccion> Direcciones { get; set; }
    public DbSet<Pago> Pagos { get; set; }
    public DbSet<Valoracion> Valoraciones { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configuraciones adicionales si es necesario (ej: relaciones)
        modelBuilder.Entity<Pedido>()
            .HasMany(p => p.Detalles)
            .WithOne(d => d.Pedido) // Asumiendo que DetallePedido tiene Pedido
            .HasForeignKey("PedidoId");

        // Seed data inicial (50% de datos de prueba)
        var restaurante1Id = Guid.Parse("3708cfb0-1263-41ec-8e4f-58bec7d860e1");
        var restaurante2Id = Guid.Parse("f354ed19-48c6-4de0-a081-f39c6220eaaf");

        modelBuilder.Entity<Restaurante>().HasData(
            new Restaurante { Id = restaurante1Id, NombreComercial = "Sushi Express", Calificacion = 4.8, TiempoEntrega = 25, Estado = EstadoRestaurante.Abierto, FechaCreacion = DateTime.UtcNow },
            new Restaurante { Id = restaurante2Id, NombreComercial = "Pizzeria Italiana", Calificacion = 4.5, TiempoEntrega = 30, Estado = EstadoRestaurante.Abierto, FechaCreacion = DateTime.UtcNow }
        );

        modelBuilder.Entity<Producto>().HasData(
            // Productos de Sushi Express
            new Producto { Id = Guid.NewGuid(), RestauranteId = restaurante1Id, Nombre = "Sushi Roll California", Descripcion = "Roll de sushi con aguacate, pepino y cangrejo", Precio = 12.50m, Categoria = "Sushi", Disponible = true, OpcionesDieteticas = new List<string> { "Vegetariano" } },
            new Producto { Id = Guid.NewGuid(), RestauranteId = restaurante1Id, Nombre = "Sashimi de Salmón", Descripcion = "Fresco sashimi de salmón noruego", Precio = 15.00m, Categoria = "Sashimi", Disponible = true, OpcionesDieteticas = new List<string> { "Sin gluten" } },
            new Producto { Id = Guid.NewGuid(), RestauranteId = restaurante1Id, Nombre = "Tempura de Camarón", Descripcion = "Camarones rebozados y fritos", Precio = 10.00m, Categoria = "Tempura", Disponible = true, OpcionesDieteticas = new List<string> { "Sin gluten" } },

            // Productos de Pizzeria Italiana
            new Producto { Id = Guid.NewGuid(), RestauranteId = restaurante2Id, Nombre = "Pizza Margherita", Descripcion = "Pizza clásica con mozzarella, tomate y albahaca", Precio = 14.00m, Categoria = "Pizza", Disponible = true, OpcionesDieteticas = new List<string> { "Vegetariano" } },
            new Producto { Id = Guid.NewGuid(), RestauranteId = restaurante2Id, Nombre = "Pasta Carbonara", Descripcion = "Pasta con salsa carbonara tradicional", Precio = 13.50m, Categoria = "Pasta", Disponible = true, OpcionesDieteticas = new List<string> { "Sin gluten opcional" } },
            new Producto { Id = Guid.NewGuid(), RestauranteId = restaurante2Id, Nombre = "Lasagna Bolognese", Descripcion = "Lasagna casera con carne y salsa boloñesa", Precio = 16.00m, Categoria = "Pasta", Disponible = true, OpcionesDieteticas = new List<string> { "Sin gluten opcional" } }
        );
    }
}