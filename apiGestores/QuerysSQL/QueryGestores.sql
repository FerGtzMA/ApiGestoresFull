use Pruebas

create table gestoresBD(
	id int primary key identity(1,1),
	nombre varchar(50) not null,
	lanzamiento int,
	desarrollador varchar(50)
)

-- Insertar información sobre SQL Server
INSERT INTO gestoresBD (nombre, lanzamiento, desarrollador) VALUES ('SQL Server', 1989, 'Microsoft');

-- Insertar información sobre MySQL
INSERT INTO gestoresBD (nombre, lanzamiento, desarrollador) VALUES ('MySQL', 1995, 'Oracle Corporation');

-- Insertar información sobre PostgreSQL
INSERT INTO gestoresBD (nombre, lanzamiento, desarrollador) VALUES ('PostgreSQL', 1996, 'PostgreSQL Global Development Group');

-- Insertar información sobre MongoDB
INSERT INTO gestoresBD (nombre, lanzamiento, desarrollador) VALUES ('MongoDB', 2009, 'MongoDB Inc.');

-- Insertar información sobre SQLite
INSERT INTO gestoresBD (nombre, lanzamiento, desarrollador) VALUES ('SQLite', 2000, 'D. Richard Hipp');


select * from gestoresBD