CREATE TABLE Autor(
    id_autor            int             NOT NULL,
    estado              varchar(50)     NOT NULL,
    nombre              varchar(100)    NOT NULL,
    apellido            varchar(100)    NOT NULL,
    sexo                char(1)         NOT NULL,
    fecha_nacimiento    datetime        NOT NULL,
    CONSTRAINT PK3 PRIMARY KEY NONCLUSTERED (id_autor)
)

go
IF OBJECT_ID('Autor') IS NOT NULL
    PRINT '<<< CREATED TABLE Autor >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Autor >>>'
go

/* 
 * TABLE: [Autor Libro] 
 */

CREATE TABLE [Autor Libro](
    id_autor    int    NOT NULL,
    id_libro    int    NOT NULL,
    CONSTRAINT PK15 PRIMARY KEY NONCLUSTERED (id_autor, id_libro)
)
go

IF OBJECT_ID('Autor Libro') IS NOT NULL
    PRINT '<<< CREATED TABLE Autor Libro >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Autor Libro >>>'
go

/* 
 * TABLE: Categoria 
 */

CREATE TABLE Categoria(
    id_categoria    int             NOT NULL,
    nombre          varchar(100)    NOT NULL,
    descripcion     varchar(100)    NOT NULL,
    CONSTRAINT PK4 PRIMARY KEY NONCLUSTERED (id_categoria)
)
go

IF OBJECT_ID('Categoria') IS NOT NULL
    PRINT '<<< CREATED TABLE Categoria >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Categoria >>>'
go

/* 
 * TABLE: Editorial 
 */

CREATE TABLE Editorial(
    id_editorial    int             NOT NULL,
    nombre          varchar(100)    NOT NULL,
    pais            varchar(50)     NOT NULL,
    CONSTRAINT PK6 PRIMARY KEY NONCLUSTERED (id_editorial)
)
go

IF OBJECT_ID('Editorial') IS NOT NULL
    PRINT '<<< CREATED TABLE Editorial >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Editorial >>>'
go

/* 
 * TABLE: Estudiante 
 */



CREATE TABLE Estudiante(
    id_estudiante       int            NOT NULL,
    cedula              varchar(10)    NOT NULL,
    nombre              varchar(50)    NOT NULL,
    apellido            varchar(50)    NOT NULL,
    fecha_nacimiento    datetime       NOT NULL,
    sexo                char(1)        NOT NULL,
    estado_civil        varchar(50)    NOT NULL,
    estado              varchar(50)    NOT NULL,
    CONSTRAINT PK2 PRIMARY KEY NONCLUSTERED (id_estudiante)
)
go

IF OBJECT_ID('Estudiante') IS NOT NULL
    PRINT '<<< CREATED TABLE Estudiante >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Estudiante >>>'
go

/* 
 * TABLE: Libro 
 */

CREATE TABLE Libro(
    id_libro            int             NOT NULL,
    estado              varchar(50)     NOT NULL,
    anio_publicacion    datetime        NOT NULL,
    tipo                varchar(100)    NOT NULL,
    nombre              varchar(100)    NOT NULL,
    id_categoria        int             NOT NULL,
    id_editorial        int             NOT NULL,
    CONSTRAINT PK1 PRIMARY KEY NONCLUSTERED (id_libro)
)
go

IF OBJECT_ID('Libro') IS NOT NULL
    PRINT '<<< CREATED TABLE Libro >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Libro >>>'
go

/* 
 * TABLE: Prestamo 
 */

CREATE TABLE Prestamo(
    id_prestamo         int            NOT NULL,
    estado              varchar(50)    NOT NULL,
    fecha_entrega       datetime       NOT NULL,
    fecha_tentativa     datetime       NOT NULL,
    fecha_devolucion    datetime       NOT NULL,
    id_estudiante       int            NOT NULL,
    CONSTRAINT PK7 PRIMARY KEY NONCLUSTERED (id_prestamo)
)
go

IF OBJECT_ID('Prestamo') IS NOT NULL
    PRINT '<<< CREATED TABLE Prestamo >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Prestamo >>>'
go

/* 
 * TABLE: [Prestamo Libro] 
 */

CREATE TABLE [Prestamo Libro](
    id_prestamo    int    NOT NULL,
    id_libro       int    NOT NULL,
    CONSTRAINT PK17 PRIMARY KEY NONCLUSTERED (id_prestamo, id_libro)
)
go

IF OBJECT_ID('Prestamo Libro') IS NOT NULL
    PRINT '<<< CREATED TABLE Prestamo Libro >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Prestamo Libro >>>'
go

/* 
 * TABLE: [Autor Libro] 
 */

ALTER TABLE [Autor Libro] ADD CONSTRAINT RefAutor66 
    FOREIGN KEY (id_autor)
    REFERENCES Autor(id_autor)
go

ALTER TABLE [Autor Libro] ADD CONSTRAINT RefLibro67 
    FOREIGN KEY (id_libro)
    REFERENCES Libro(id_libro)
go

/* 
 * TABLE: Libro 
 */

ALTER TABLE Libro ADD CONSTRAINT RefCategoria38 
    FOREIGN KEY (id_categoria)
    REFERENCES Categoria(id_categoria)
go

ALTER TABLE Libro ADD CONSTRAINT RefEditorial39 
    FOREIGN KEY (id_editorial)
    REFERENCES Editorial(id_editorial)
go

/* 
 * TABLE: Prestamo 
 */

ALTER TABLE Prestamo ADD CONSTRAINT RefEstudiante40 
    FOREIGN KEY (id_estudiante)
    REFERENCES Estudiante(id_estudiante)
go

/* 
 * TABLE: [Prestamo Libro] 
 */

ALTER TABLE [Prestamo Libro] ADD CONSTRAINT RefPrestamo72 
    FOREIGN KEY (id_prestamo)
    REFERENCES Prestamo(id_prestamo)
go

ALTER TABLE [Prestamo Libro] ADD CONSTRAINT RefLibro73 
    FOREIGN KEY (id_libro)
    REFERENCES Libro(id_libro)
go