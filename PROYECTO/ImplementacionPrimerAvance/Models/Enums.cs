namespace FoodApp.PrimerAvance.Models;

public enum EstadoPedido
{
    Pendiente,
    Confirmado,
    Preparando,
    EnCamino,
    Entregado,
    Cancelado
}

public enum EstadoRestaurante
{
    Abierto,
    Cerrado,
    Ocupado
}

public enum EstadoPago
{
    Pendiente,
    Procesando,
    Completado,
    Fallido
}

public enum TipoPago
{
    Tarjeta,
    Efectivo,
    BilleteraDigital
}