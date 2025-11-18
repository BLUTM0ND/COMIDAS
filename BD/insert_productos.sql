-- Script para insertar productos de prueba en la base de datos foodapp_db
-- Ejecutar después de aplicar las migraciones EF Core

INSERT INTO "Productos" ("Id", "RestauranteId", "Nombre", "Descripcion", "Precio", "Categoria", "Disponible", "Imagen", "OpcionesDieteticas")
VALUES
    -- Productos de Sushi Express
    ('550e8400-e29b-41d4-a716-446655440000', '3708cfb0-1263-41ec-8e4f-58bec7d860e1', 'Sushi Roll California', 'Roll de sushi con aguacate, pepino y cangrejo', 12.50, 'Sushi', true, NULL, ARRAY['Vegetariano']),
    ('550e8400-e29b-41d4-a716-446655440001', '3708cfb0-1263-41ec-8e4f-58bec7d860e1', 'Sashimi de Salmón', 'Fresco sashimi de salmón noruego', 15.00, 'Sashimi', true, NULL, ARRAY['Sin gluten']),
    ('550e8400-e29b-41d4-a716-446655440002', '3708cfb0-1263-41ec-8e4f-58bec7d860e1', 'Tempura de Camarón', 'Camarones rebozados y fritos', 10.00, 'Tempura', true, NULL, ARRAY['Sin gluten']),

    -- Productos de Pizzeria Italiana
    ('550e8400-e29b-41d4-a716-446655440003', 'f354ed19-48c6-4de0-a081-f39c6220eaaf', 'Pizza Margherita', 'Pizza clásica con mozzarella, tomate y albahaca', 14.00, 'Pizza', true, NULL, ARRAY['Vegetariano']),
    ('550e8400-e29b-41d4-a716-446655440004', 'f354ed19-48c6-4de0-a081-f39c6220eaaf', 'Pasta Carbonara', 'Pasta con salsa carbonara tradicional', 13.50, 'Pasta', true, NULL, ARRAY['Sin gluten opcional']),
    ('550e8400-e29b-41d4-a716-446655440005', 'f354ed19-48c6-4de0-a081-f39c6220eaaf', 'Lasagna Bolognese', 'Lasagna casera con carne y salsa boloñesa', 16.00, 'Pasta', true, NULL, ARRAY['Sin gluten opcional']);