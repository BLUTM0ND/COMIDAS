using System;

namespace FoodApp.PrimerAvance.Models;

public class Direccion
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Calle { get; set; }
    public string? Numero { get; set; }
    public string? Ciudad { get; set; }
    public string? Referencia { get; set; }
    public bool Predeterminada { get; set; }
    public string? CoordenadasGPS { get; set; }

    public bool ValidarDireccion() => !string.IsNullOrWhiteSpace(Calle) && !string.IsNullOrWhiteSpace(Ciudad);
}
