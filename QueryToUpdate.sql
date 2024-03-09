use MetroApp


-- Nombre: Saul 
-- Fecha: 08/03/2024
-- Descripcion: Falto agregar el campo apellido a la tabla y el estado del usuario en bit.

ALTER TABLE Usuarios
ADD Apellido NVARCHAR(80);

ALTER TABLE Usuarios
ALTER COLUMN EstadoUsuario BIT;

---------------------------------------------------------------------------------------------