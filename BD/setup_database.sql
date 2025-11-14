-- Script completo para configurar la base de datos foodapp_db en PostgreSQL
-- Ejecutar este script en pgAdmin o psql con usuario postgres

-- Crear la base de datos
CREATE DATABASE foodapp_db
    WITH
    OWNER = postgres
    ENCODING = 'UTF8'
    LC_COLLATE = 'Spanish_Spain.1252'
    LC_CTYPE = 'Spanish_Spain.1252'
    TABLESPACE = pg_default
    CONNECTION LIMIT = -1
    IS_TEMPLATE = false;

-- Conectar a la base de datos (en psql usar \c foodapp_db)
-- En pgAdmin, ejecutar el resto del script en la DB foodapp_db

-- Crear tabla de historial de migraciones
CREATE TABLE "__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
);

-- Crear tabla Pagos
CREATE TABLE "Pagos" (
    "Id" uuid NOT NULL,
    "Monto" numeric NOT NULL,
    "Fecha" timestamp with time zone NOT NULL,
    "Estado" integer NOT NULL,
    "TipoTarjeta" text,
    "DatosEncriptados" text,
    CONSTRAINT "PK_Pagos" PRIMARY KEY ("Id")
);

-- Crear tabla Restaurantes
CREATE TABLE "Restaurantes" (
    "Id" uuid NOT NULL,
    "NombreComercial" text,
    "Ruc" text,
    "DireccionTexto" text,
    "TiempoEntrega" integer NOT NULL,
    "Calificacion" double precision NOT NULL,
    "Estado" integer NOT NULL,
    "UbicacionGPS" text,
    "FechaCreacion" timestamp with time zone NOT NULL,
    CONSTRAINT "PK_Restaurantes" PRIMARY KEY ("Id")
);

-- Crear tabla Usuarios
CREATE TABLE "Usuarios" (
    "Id" uuid NOT NULL,
    "Email" text,
    "ContrasenaHash" text,
    "Telefono" text,
    "FechaRegistro" timestamp with time zone NOT NULL,
    "Discriminator" character varying(13) NOT NULL,
    "Vehiculo" text,
    "Licencia" text,
    "Zona" text,
    "Disponible" boolean,
    CONSTRAINT "PK_Usuarios" PRIMARY KEY ("Id")
);

-- Crear tabla Valoraciones
CREATE TABLE "Valoraciones" (
    "Id" uuid NOT NULL,
    "CalificacionRestaurante" integer NOT NULL,
    "CalificacionPedido" integer NOT NULL,
    "Comentario" text,
    "FechaValoracion" timestamp with time zone NOT NULL,
    CONSTRAINT "PK_Valoraciones" PRIMARY KEY ("Id")
);

-- Crear tabla Productos
CREATE TABLE "Productos" (
    "Id" uuid NOT NULL,
    "RestauranteId" uuid NOT NULL,
    "Nombre" text,
    "Descripcion" text,
    "Precio" numeric NOT NULL,
    "Categoria" text,
    "Disponible" boolean NOT NULL,
    "Imagen" text,
    "OpcionesDieteticas" text[] NOT NULL,
    CONSTRAINT "PK_Productos" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Productos_Restaurantes_RestauranteId" FOREIGN KEY ("RestauranteId") REFERENCES "Restaurantes" ("Id") ON DELETE CASCADE
);

-- Crear tabla Direcciones
CREATE TABLE "Direcciones" (
    "Id" uuid NOT NULL,
    "Calle" text,
    "Numero" text,
    "Ciudad" text,
    "Referencia" text,
    "Predeterminada" boolean NOT NULL,
    "CoordenadasGPS" text,
    "ClienteId" uuid,
    CONSTRAINT "PK_Direcciones" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Direcciones_Usuarios_ClienteId" FOREIGN KEY ("ClienteId") REFERENCES "Usuarios" ("Id")
);

-- Crear tabla Pedidos
CREATE TABLE "Pedidos" (
    "Id" uuid NOT NULL,
    "FechaPedido" timestamp with time zone NOT NULL,
    "Estado" integer NOT NULL,
    "Total" numeric NOT NULL,
    "TiempoEstimado" integer NOT NULL,
    "MetodoPago" integer NOT NULL,
    "Propina" numeric NOT NULL,
    "Descuento" numeric NOT NULL,
    "DireccionEntregaId" uuid,
    "PagoId" uuid,
    "ClienteId" uuid,
    CONSTRAINT "PK_Pedidos" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Pedidos_Direcciones_DireccionEntregaId" FOREIGN KEY ("DireccionEntregaId") REFERENCES "Direcciones" ("Id"),
    CONSTRAINT "FK_Pedidos_Pagos_PagoId" FOREIGN KEY ("PagoId") REFERENCES "Pagos" ("Id"),
    CONSTRAINT "FK_Pedidos_Usuarios_ClienteId" FOREIGN KEY ("ClienteId") REFERENCES "Usuarios" ("Id")
);

-- Crear tabla DetallesPedido
CREATE TABLE "DetallesPedido" (
    "Id" uuid NOT NULL,
    "PedidoId" uuid NOT NULL,
    "ProductoId" uuid NOT NULL,
    "Cantidad" integer NOT NULL,
    "Precio" numeric NOT NULL,
    "Observaciones" text,
    "OpcionesPersonalizables" text[] NOT NULL,
    CONSTRAINT "PK_DetallesPedido" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_DetallesPedido_Pedidos_PedidoId" FOREIGN KEY ("PedidoId") REFERENCES "Pedidos" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_DetallesPedido_Productos_ProductoId" FOREIGN KEY ("ProductoId") REFERENCES "Productos" ("Id") ON DELETE CASCADE
);

-- Crear índices
CREATE INDEX "IX_DetallesPedido_PedidoId" ON "DetallesPedido" ("PedidoId");
CREATE INDEX "IX_DetallesPedido_ProductoId" ON "DetallesPedido" ("ProductoId");
CREATE INDEX "IX_Direcciones_ClienteId" ON "Direcciones" ("ClienteId");
CREATE INDEX "IX_Pedidos_ClienteId" ON "Pedidos" ("ClienteId");
CREATE INDEX "IX_Pedidos_DireccionEntregaId" ON "Pedidos" ("DireccionEntregaId");
CREATE INDEX "IX_Pedidos_PagoId" ON "Pedidos" ("PagoId");
CREATE INDEX "IX_Productos_RestauranteId" ON "Productos" ("RestauranteId");

-- Insertar historial de migraciones
INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20251113002440_InitialCreate', '8.0.0');

-- Insertar datos de prueba - Restaurantes
INSERT INTO "Restaurantes" ("Id", "Calificacion", "DireccionTexto", "Estado", "FechaCreacion", "NombreComercial", "Ruc", "TiempoEntrega", "UbicacionGPS")
VALUES
    ('3708cfb0-1263-41ec-8e4f-58bec7d860e1', 4.8, NULL, 0, '2025-11-13 00:24:38.984934+00', 'Sushi Express', NULL, 25, NULL),
    ('f354ed19-48c6-4de0-a081-f39c6220eaaf', 4.5, NULL, 0, '2025-11-13 00:24:38.984933+00', 'Pizzeria Italiana', NULL, 30, NULL);

-- Insertar datos de prueba - Productos
INSERT INTO "Productos" ("Id", "RestauranteId", "Nombre", "Descripcion", "Precio", "Categoria", "Disponible", "OpcionesDieteticas")
VALUES
    -- Productos de Sushi Express
    ('550e8400-e29b-41d4-a716-446655440000', '3708cfb0-1263-41ec-8e4f-58bec7d860e1', 'Sushi Roll California', 'Roll de sushi con aguacate, pepino y cangrejo', 12.50, 'Sushi', true, ARRAY['Vegetariano']),
    ('550e8400-e29b-41d4-a716-446655440001', '3708cfb0-1263-41ec-8e4f-58bec7d860e1', 'Sashimi de Salmón', 'Fresco sashimi de salmón noruego', 15.00, 'Sashimi', true, ARRAY['Sin gluten']),
    ('550e8400-e29b-41d4-a716-446655440002', '3708cfb0-1263-41ec-8e4f-58bec7d860e1', 'Tempura de Camarón', 'Camarones rebozados y fritos', 10.00, 'Tempura', true, ARRAY['Sin gluten']),

    -- Productos de Pizzeria Italiana
    ('550e8400-e29b-41d4-a716-446655440003', 'f354ed19-48c6-4de0-a081-f39c6220eaaf', 'Pizza Margherita', 'Pizza clásica con mozzarella, tomate y albahaca', 14.00, 'Pizza', true, ARRAY['Vegetariano']),
    ('550e8400-e29b-41d4-a716-446655440004', 'f354ed19-48c6-4de0-a081-f39c6220eaaf', 'Pasta Carbonara', 'Pasta con salsa carbonara tradicional', 13.50, 'Pasta', true, ARRAY['Sin gluten opcional']),
    ('550e8400-e29b-41d4-a716-446655440005', 'f354ed19-48c6-4de0-a081-f39c6220eaaf', 'Lasagna Bolognese', 'Lasagna casera con carne y salsa boloñesa', 16.00, 'Pasta', true, ARRAY['Sin gluten opcional']);

-- Otorgar permisos
GRANT ALL PRIVILEGES ON DATABASE foodapp_db TO postgres;
GRANT ALL ON ALL TABLES IN SCHEMA public TO postgres;
GRANT ALL ON ALL SEQUENCES IN SCHEMA public TO postgres;