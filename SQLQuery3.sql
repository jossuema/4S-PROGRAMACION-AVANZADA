INSERT INTO Estudiante (id_estudiante, cedula, nombre, apellido, fecha_nacimiento, sexo, estado_civil, estado) VALUES 
(1, 'V12345678', 'Josue', 'Malla', '2004-10-28', 'M', 'Soltero', 'Activo'),
(2, 'V87654321', 'Gabriela', 'Guayas', '2004-03-14', 'F', 'Casada', 'Activo'),
(3, 'V23456789', 'Carlos', 'Jiménez', '1991-03-03', 'M', 'Soltero', 'Activo'),
(4, 'V98765432', 'Ana', 'Martínez', '1993-04-04', 'F', 'Soltera', 'Activo'),
(5, 'V34567890', 'Luis', 'Rodríguez', '1994-05-05', 'M', 'Casado', 'Activo'),
(6, 'V09876543', 'Sofía', 'López', '1995-06-06', 'F', 'Soltera', 'Activo'),
(7, 'V45678901', 'Gabriel', 'Hernández', '1990-07-07', 'M', 'Soltero', 'Activo'),
(8, 'V10987654', 'Lucía', 'Fernández', '1992-08-08', 'F', 'Casada', 'Activo'),
(9, 'V56789012', 'David', 'García', '1991-09-09', 'M', 'Soltero', 'Activo'),
(10, 'V21098765', 'Elena', 'Díaz', '1993-10-10', 'F', 'Soltera', 'Activo');

DELETE FROM Estudiante WHERE nombre = 'Elena' AND apellido = 'Díaz';

UPDATE Estudiante SET nombre = 'Manuel' WHERE id_estudiante = 1;

SELECT * FROM Estudiante;

INSERT INTO Editorial (id_editorial, nombre, pais) VALUES
(1, 'Editorial Alpha', 'España'),
(2, 'Beta Publishers', 'Estados Unidos'),
(3, 'Gamma Press', 'Reino Unido'),
(4, 'Delta Books', 'Alemania'),
(5, 'Epsilon Media', 'Francia'),
(6, 'Zeta House', 'Italia'),
(7, 'Eta Publishing', 'Canadá'),
(8, 'Theta Literature', 'Australia'),
(9, 'Iota Publications', 'Japón'),
(10, 'Kappa Editions', 'Brasil');

DELETE FROM Editorial WHERE id_editorial = 10;

UPDATE Editorial SET pais = 'Ecuador' WHERE id_editorial = 5;

SELECT * FROM Editorial;

INSERT INTO Categoria (id_categoria, nombre, descripcion) VALUES 
(1, 'Ficción', 'Novelas y cuentos ficticios'),
(2, 'No Ficción', 'Obras basadas en hechos reales'),
(3, 'Ciencia', 'Libros de ciencia y tecnología'),
(4, 'Historia', 'Libros sobre eventos históricos'),
(5, 'Arte', 'Libros relacionados con el arte'),
(6, 'Educación', 'Materiales educativos y de aprendizaje'),
(7, 'Viajes', 'Guías de viaje y relatos'),
(8, 'Autoayuda', 'Libros de motivación y autoayuda'),
(9, 'Cocina', 'Libros de recetas y cocina'),
(10, 'Deporte', 'Libros sobre deportes y actividades físicas');

DELETE FROM Categoria WHERE id_categoria = 1;

UPDATE Categoria SET descripcion = 'Viajes y relatos' WHERE id_categoria = 7;

SELECT * FROM Categoria;



INSERT INTO Autor (id_autor, estado, nombre, apellido, sexo, fecha_nacimiento) VALUES 
(1, 'Activo', 'Gabriel', 'García Márquez', 'M', '1927-03-06'),
(2, 'Activo', 'Isabel', 'Allende', 'F', '1942-08-02'),
(3, 'Activo', 'J.K.', 'Rowling', 'F', '1965-07-31'),
(4, 'Activo', 'Stephen', 'King', 'M', '1947-09-21'),
(5, 'Activo', 'Ken', 'Follett', 'M', '1949-06-05'),
(6, 'Activo', 'Haruki', 'Murakami', 'M', '1949-01-12'),
(7, 'Activo', 'Paulo', 'Coelho', 'M', '1947-08-24'),
(8, 'Activo', 'Margaret', 'Atwood', 'F', '1939-11-18');

DELETE FROM Autor WHERE id_autor = 1;

UPDATE Autor SET apellido = 'Marquez' WHERE id_autor = 1;

SELECT * FROM Autor;


INSERT INTO Libro (id_libro, estado, anio_publicacion, tipo, nombre, id_categoria, id_editorial) VALUES 
(1, 'Disponible', '2021-01-01', 'Libro', 'Los Jardines de la Luna', 1, 1),
(2, 'Prestado', '2020-11-10', 'Artículo', 'Innovaciones en la Era Digital', 3, 2),
(3, 'Disponible', '2018-06-20', 'Revista', 'Historia Viva Ed. 27', 4, 3),
(4, 'Disponible', '2019-03-15', 'Libro', 'El Arte del Renacimiento', 5, 4),
(5, 'Prestado', '2020-07-22', 'Revista', 'Educación del Futuro Vol. 3', 6, 5),
(6, 'Disponible', '2021-08-05', 'Artículo', 'Descubriendo Nuevos Destinos', 7, 6),
(7, 'Prestado', '2017-09-19', 'Libro', 'El Camino Menos Recorrido', 8, 7),
(8, 'Disponible', '2019-04-12', 'Revista', 'Sabores del Mundo Nº 5', 9, 8),
(9, 'Disponible', '2020-12-30', 'Artículo', 'La Era de los Deportes Electrónicos', 10, 9),
(10, 'Prestado', '2018-02-28', 'Libro', 'Crónicas de un Viajero', 7, 10);

DELETE FROM Libro WHERE id_libro = 10;

DELETE FROM Libro WHERE id_categoria = 1;

DELETE FROM Libro WHERE id_editorial = 10;

UPDATE Libro SET estado = 'Prestado' WHERE tipo = 'Libro';

SELECT * FROM Libro;

INSERT INTO [Autor Libro] (id_autor, id_libro) VALUES 
(1, 1),
(2, 2),
(3, 3),
(1, 4),
(2, 5),
(3, 6),
(1, 7), 
(2, 8),
(3, 9),
(1, 10);

DELETE FROM [Autor Libro] WHERE id_libro = 1;

DELETE FROM [Prestamo Libro] WHERE id_libro = 1;

DELETE FROM [Autor Libro] WHERE id_autor = 1;

UPDATE [Autor Libro] SET id_autor = 5 WHERE id_autor = 3;

SELECT * FROM [Autor Libro];


INSERT INTO Prestamo (id_prestamo, estado, fecha_entrega, fecha_tentativa, fecha_devolucion, id_estudiante) VALUES 
(1, 'En Curso', '2024-01-10', '2024-01-24', '2024-02-10', 1),
(2, 'Finalizado', '2024-01-12', '2024-01-26', '2024-02-12', 2),
(3, 'En Curso', '2024-01-15', '2024-01-29', '2024-02-15', 3),
(4, 'Finalizado', '2024-01-18', '2024-02-01', '2024-02-18', 4),
(5, 'En Curso', '2024-01-20', '2024-02-03', '2024-02-20', 5),
(6, 'Finalizado', '2024-01-22', '2024-02-05', '2024-02-22', 6),
(7, 'En Curso', '2024-01-25', '2024-02-08', '2024-02-25', 7),
(8, 'Finalizado', '2024-01-28', '2024-02-11', '2024-02-28', 8),
(9, 'En Curso', '2024-01-30', '2024-02-13', '2024-03-01', 9),
(10, 'Finalizado', '2024-02-02', '2024-02-16', '2024-03-02', 10);

DELETE FROM Prestamo WHERE id_prestamo = 10;

UPDATE Prestamo SET estado = 'Finalizado' WHERE fecha_tentativa = '2024-02-03';

SELECT * FROM Prestamo;

INSERT INTO [Prestamo Libro] (id_prestamo, id_libro) VALUES 
(1, 1),
(3, 3),
(4, 4),
(5, 5),
(6, 6),
(7, 7),
(8, 8),
(9, 9),
(10, 10);

DELETE FROM [Prestamo Libro] WHERE id_libro = 10;

UPDATE [Prestamo Libro] SET id_prestamo = 5 WHERE id_prestamo = 6;

SELECT * FROM [Prestamo Libro];

SELECT * FROM Libro;
SELECT COUNT(id_libro) as CantidadLibros from Libro WHERE tipo = 'libro';

EXEC [dbo].[CP_ListarLibros]