use MetroApp


-- Nombre: Saul 
-- Fecha: 08/03/2024
-- Descripcion: Falto agregar el campo apellido a la tabla, el estado del usuario en bit, tipo de campo de telefono.

ALTER TABLE Usuarios
ADD Apellido NVARCHAR(80);

ALTER TABLE Usuarios
ALTER COLUMN EstadoUsuario BIT;

ALTER TABLE Usuarios
ALTER COLUMN Telefono NVARCHAR(30);

---------------------------------------------------------------------------------------------