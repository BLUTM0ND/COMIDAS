# Alineamiento RF/RNF y Diagrama de Clases - Primer Avance

Este documento mapea cada Requerimiento Funcional (RF) y No Funcional (RNF) al conjunto de clases/elementos del diagrama de clases.

## Requerimientos Funcionales -> Clases relevantes (resumen)
- RF1: Registro y Autenticación de Usuarios -> `Usuario`, `Cliente`, `Repartidor` (métodos: iniciarSesion, recuperarContraseña)
- RF2: Exploración de Restaurantes -> `Restaurante`, `BusquedaYFiltros` (filtros por tipo, distancia, calificaciones)
- RF3: Visualización de Menús -> `Restaurante` -> `Producto` (menu con descripciones, precio, imagen, opciones)
- RF4: Carrito de Compras -> `DetallePedido` (carrito temporal en `Visitante`/`Cliente`)
- RF5: Proceso de Checkout -> `Pedido`, `Pago`, `Direccion`, `TipoPago` (selección método, dirección, confirmación)
- RF6: Seguimiento de Pedidos -> `Pedido`, `EstadoPedido`, notificaciones (`IServicioMensajeria`)
- RF7: Gestión de Restaurantes -> `Restaurante` (panel para actualizar `Producto` y gestionar `Pedido`)
- RF8: Valoraciones y Reseñas -> `Valoracion`, vinculada a `Pedido` y `Restaurante`.
- RF9: Búsqueda y Filtros Avanzados -> `BusquedaYFiltros`, `Producto`, `Restaurante`.
- RF10: Integración con Servicios Externos -> `IServicioMapas`, `IServicioPagos`, `IServicioMensajeria`.

## Requerimientos No Funcionales -> Consideraciones de diseño (resumen)
- RNF1 (Rendimiento): Cargar menús y búsquedas debe ser rápido -> diseñar repositorios/servicios con caching (no implementado en este primer avance).
- RNF2 (Seguridad): Encriptación y MFA -> `Pago` almacena datos encriptados; la infraestructura de autenticación se documentará en próximos avances.
- RNF3 (Usabilidad): UI/UX para móvil -> fuera del alcance (implementación futura), interfaces diseñadas para soportar DTOs ligeros.
- RNF4 (Escalabilidad): Separar capas (Domain, Application, Infrastructure) en próximos avances.
- RNF5-RNF10: Notas incluidas como requisitos de arquitectura futura.

## Observaciones
- Este primer avance implementa las clases de dominio y las interfaces base. Las implementaciones concretas (repositorios, persistencia, APIs, seguridad, notificaciones) se desarrollarán en las siguientes iteraciones.
