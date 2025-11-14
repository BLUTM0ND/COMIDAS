namespace FoodApp.PrimerAvance.Interfaces;

public interface IServicioMensajeria
{
    void EnviarNotificacion(string destino, string mensaje);
    void EnviarSMS(string telefono, string mensaje);
    void EnviarEmail(string correo, string mensaje);
}
