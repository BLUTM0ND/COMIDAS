namespace FoodApp.PrimerAvance.Interfaces;

public interface IServicioMapas
{
    string ObtenerUbicacion(string direccion);
    float CalcularDistancia(string origen, string destino);
    void MostrarRuta(string origen, string destino);
}
