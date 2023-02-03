--INGRESO AL ADMIN POR BASE DE DATOS

INSERT INTO Users
(IdWeb, [Document], [Name], UserEmail, Phone, Birthday, Rol, Password, InsertDate, UpdateDate, IsActive)
VALUES
(NEWID(), 29501911L, 'Eva', 'miemail@gmail.com', 123456789, '1995-09-13 00:00:00', 1, 'micontraseña', GETDATE(), GETDATE(), 1)

SELECT * FROM Users

INSERT INTO UserRol
([Title], [Description], InsertDate, UpdateDate, IsActive)
VALUES
('Admin', 'All permissions', GETDATE(), GETDATE(), 1)

SELECT * FROM UserRol

INSERT INTO Admins
(IdPerson, IdRol, [Name], CompanyName, CompanyEmail)
VALUES
(1, 1, 'Eva', 'miempresa', 'miempresaemail@gmail.com')

SELECT * FROM Users