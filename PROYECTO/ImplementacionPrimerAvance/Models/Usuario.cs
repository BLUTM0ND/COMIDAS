using System;

namespace FoodApp.PrimerAvance.Models;

public class Usuario
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Email { get; set; }
    public string? ContrasenaHash { get; set; }
    public string? Telefono { get; set; }
    public DateTime FechaRegistro { get; set; } = DateTime.UtcNow;

    // Métodos de negocio simples (a implementar)
    public bool IniciarSesion(string email, string passwordHash) => Email == email && ContrasenaHash == passwordHash;
    public void RecuperarContrasena() { /* enviar email o sms - implementación futura */ }
}
