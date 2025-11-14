-- Script para insertar productos de prueba en la base de datos foodapp_db
-- Ejecutar después de aplicar las migraciones EF Core

-- IDs de restaurantes (deben coincidir con los seed data)
-- Sushi Express: 3708cfb0-1263-41ec-8e4f-58bec7d860e1
-- Pizzeria Italiana: f354ed19-48c6-4de0-a081-f39c6220eaaf

INSERT INTO "Productos" ("Id", "RestauranteId", "Nombre", "Descripcion", "Precio", "Categoria", "Disponible", "OpcionesDieteticas")
VALUES
    -- Productos de Sushi Express
    (gen_random_uuid(), '3708cfb0-1263-41ec-8e4f-58bec7d860e1', 'Sushi Roll California', 'Roll de sushi con aguacate, pepino y cangrejo', 12.50, 'Sushi', true, ARRAY['Vegetariano']),
    (gen_random_uuid(), '3708cfb0-1263-41ec-8e4f-58bec7d860e1', 'Sashimi de Salmón', 'Fresco sashimi de salmón noruego', 15.00, 'Sashimi', true, ARRAY['Sin gluten']),
    (gen_random_uuid(), '3708cfb0-1263-41ec-8e4f-58bec7d860e1', 'Tempura de Camarón', 'Camarones rebozados y fritos', 10.00, 'Tempura', true, ARRAY['Sin gluten']),

    -- Productos de Pizzeria Italiana
    (gen_random_uuid(), 'f354ed19-48c6-4de0-a081-f39c6220eaaf', 'Pizza Margherita', 'Pizza clásica con mozzarella, tomate y albahaca', 14.00, 'Pizza', true, ARRAY['Vegetariano']),
    (gen_random_uuid(), 'f354ed19-48c6-4de0-a081-f39c6220eaaf', 'Pasta Carbonara', 'Pasta con salsa carbonara tradicional', 13.50, 'Pasta', true, ARRAY['Sin gluten opcional']),
    (gen_random_uuid(), 'f354ed19-48c6-4de0-a081-f39c6220eaaf', 'Lasagna Bolognese', 'Lasagna casera con carne y salsa boloñesa', 16.00, 'Pasta', true, ARRAY['Sin gluten opcional']);