# Carpeta BD - Scripts de Base de Datos

Esta carpeta contiene scripts SQL para configurar la base de datos PostgreSQL del proyecto FoodApp.

## Archivos:
- `create_database.sql`: Script básico para crear la base de datos `foodapp_db`.
- `setup_database.sql`: **SCRIPT COMPLETO** - Crea DB, tablas, índices, constraints y datos de prueba (recomendado para presentación).
- `insert_productos.sql`: Solo inserta productos (si ya tienes las tablas creadas).

## Instrucciones Rápidas:
1. **Opción Recomendada:** Ejecuta `setup_database.sql` en pgAdmin (crea todo de una vez).
2. O ejecuta `create_database.sql` + luego usa EF Core: `dotnet ef database update`.

**Estado Actual: 100% de Integración DB Completada**
- Restaurantes cargados desde BD ✅
- Productos cargados desde BD ✅
- Frontend actualizado para mostrar productos dinámicos desde BD ✅
- Datos de prueba incluidos en setup_database.sql ✅