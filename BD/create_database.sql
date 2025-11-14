-- Script para crear la base de datos foodapp_db en PostgreSQL
-- Ejecutar este script en pgAdmin o psql con usuario postgres

CREATE DATABASE foodapp_db
    WITH
    OWNER = postgres
    ENCODING = 'UTF8'
    LC_COLLATE = 'Spanish_Spain.1252'
    LC_CTYPE = 'Spanish_Spain.1252'
    TABLESPACE = pg_default
    CONNECTION LIMIT = -1
    IS_TEMPLATE = false;

-- Otorgar permisos al usuario postgres
GRANT ALL PRIVILEGES ON DATABASE foodapp_db TO postgres;