# Primer Avance - Aplicativo de Pedidos de Comida (C#)

Este primer avance contiene:

- Un proyecto C# de consola con los modelos del dominio y las interfaces base.
- Un documento que alinea los Requerimientos Funcionales (RF) y No Funcionales (RNF) con las clases del diagrama.
- **Nuevo: Frontend básico con ASP.NET Core Razor Pages** - Página principal que lista restaurantes y muestra menús con HTML/CSS/JS.
- **Nuevo: Integración con PostgreSQL (50%)** - EF Core configurado, migraciones creadas, modelos con FKs, datos seed iniciales.

Rutas importantes:
- `PROYECTO/ImplementacionPrimerAvance/Models` - entidades del dominio.
- `PROYECTO/ImplementacionPrimerAvance/Interfaces` - interfaces de integración.
- `PROYECTO/ImplementacionPrimerAvance/alineacion_RF_DIAGRAMA.md` - alineamiento RF/RNF con diagrama.
- `PROYECTO/ImplementacionPrimerAvance/Pages/Index.cshtml` - página web principal.
- `PROYECTO/ImplementacionPrimerAvance/wwwroot/css/site.css` - estilos CSS.
- `PROYECTO/ImplementacionPrimerAvance/Data/ApplicationDbContext.cs` - contexto de DB.
- `PROYECTO/ImplementacionPrimerAvance/Migrations/` - migraciones EF Core.

Cómo ejecutar (requiere .NET 8+ y PostgreSQL corriendo):

**Opción 1 - Script Completo (Recomendado para presentación):**
1. Ejecuta `BD/setup_database.sql` en pgAdmin (crea DB, tablas y datos de una vez).
2. Ejecutar: `dotnet run --urls=http://localhost:5000`

**Opción 2 - Usando EF Core:**
1. Crear la base de datos: Ejecuta `BD/create_database.sql` en pgAdmin.
2. Aplicar migraciones: `dotnet ef database update` (crea tablas y seed restaurantes).
3. Insertar productos: Ejecuta `BD/insert_productos.sql` en pgAdmin.
4. Ejecutar: `dotnet run --urls=http://localhost:5000`

Abre http://localhost:5000 en tu navegador para ver la página web con restaurantes y menús interactivos (cargados desde DB).

**Nota:** La integración DB está al 50% - carga restaurantes desde DB, productos desde script SQL. La app está corriendo actualmente en http://localhost:5000.
