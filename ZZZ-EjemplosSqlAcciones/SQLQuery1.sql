INSERT INTO Clientes (Nombre, Apellido, DNI) VALUES('Juan', 'Perez', '11111111');
Select * FROM Clientes;
insert into Clientes(Nombre, Apellido, DNI) VALUES ('Pepe', 'Argento', '22222222');
insert into clientes(Nombre, Apellido, DNI, Fecha_nacimiento) VALUES('Jose', 'Gimenez', '33333333', '1995/07/02');

select * From Clientes Where nombre = 'lol';

Delete from clientes where id = 24 and id=25 and id=23 and id=22;

update Clientes set nombre='pepeLuis' where id=1;

select * FROM Clientes where id=1;