using System;

namespace FoodApp.PrimerAvance.Interfaces;

public interface IServicioPagos
{
    bool ProcesarTransaccion(decimal monto, string datosPagoEncriptados);
    bool ValidarPago(string datos);
    bool Reembolsar(Guid pagoId);
}
