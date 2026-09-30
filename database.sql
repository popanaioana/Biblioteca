USE master;
GO

/*DATABASE*/

IF DB_ID('BibliotecaDB') IS NOT NULL
BEGIN
    ALTER DATABASE BibliotecaDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE BibliotecaDB;
END
GO

CREATE DATABASE BibliotecaDB;
GO

USE BibliotecaDB;
GO

/*TABLES*/

CREATE TABLE Persoana
(
    IdPresoana INT IDENTITY(1,1) PRIMARY KEY,
    Nume NVARCHAR(50) NOT NULL,
    Prenume NVARCHAR(50) NOT NULL,
    Telefon NVARCHAR(20) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    Parola NVARCHAR(100) NOT NULL,
    DataNasterii DATE NOT NULL,
    Adresa NVARCHAR(200) NOT NULL
);
GO

CREATE TABLE Biblioteca
(
    IdCarte INT IDENTITY(1,1) PRIMARY KEY,
    Titlu NVARCHAR(150) NOT NULL,
    Autor NVARCHAR(100) NOT NULL,
    -- 1 = available
    -- 0 = borrowed
    Disponibilitate INT NOT NULL DEFAULT 1,
    IdPersoana INT NULL,
    DataImprumutarii DATETIME NULL,
    DataReturnarii DATETIME NULL,
    CONSTRAINT FK_Biblioteca_Persoana
        FOREIGN KEY (IdPersoana)
        REFERENCES Persoana(IdPresoana)
);
GO

/*STORED PROCEDURES*/

/* Add a new book */
CREATE PROCEDURE spInsertCarte
    @titlu NVARCHAR(150),
    @autor NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT OFF;

    INSERT INTO Biblioteca
        (Titlu, Autor, Disponibilitate)
    VALUES
        (@titlu, @autor, 1);
END
GO

/* Add a new person */
CREATE PROCEDURE spInsertPersoana
    @nume NVARCHAR(50),
    @prenume NVARCHAR(50),
    @telefon NVARCHAR(20),
    @email NVARCHAR(100),
    @parola NVARCHAR(100),
    @datanasterii DATE,
    @adresa NVARCHAR(200)
AS
BEGIN
    SET NOCOUNT OFF;

    INSERT INTO Persoana
        (Nume, Prenume, Telefon, Email, Parola, DataNasterii, Adresa)
    VALUES
        (@nume, @prenume, @telefon, @email, @parola, @datanasterii, @adresa);
END
GO

/* Borrow a book */
CREATE PROCEDURE spImprumuta
    @idCarte INT,
    @disponibilitate INT,
    @idPersoana INT,
    @dataImprumutarii DATETIME,
    @dataReturnarii DATETIME
AS
BEGIN
    SET NOCOUNT OFF;

    UPDATE Biblioteca
    SET Disponibilitate = @disponibilitate,
        IdPersoana = @idPersoana,
        DataImprumutarii = @dataImprumutarii,
        DataReturnarii = @dataReturnarii
    WHERE IdCarte = @idCarte
      AND Disponibilitate = 1;
END
GO

/* Return a book */
CREATE PROCEDURE spReturneaza
    @idCarte INT,
    @disponibilitate INT
AS
BEGIN
    SET NOCOUNT OFF;

    UPDATE Biblioteca
    SET Disponibilitate = @disponibilitate,
        IdPersoana = NULL,
        DataImprumutarii = NULL,
        DataReturnarii = NULL
    WHERE IdCarte = @idCarte;
END
GO

/* Get the book borrowed by a person */
CREATE PROCEDURE spCarteImprumutata
    @idPersoana INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        Titlu,
        Autor,
        DataImprumutarii,
        DataReturnarii
    FROM Biblioteca
    WHERE IdPersoana = @idPersoana
      AND Disponibilitate = 0;
END
GO

/* Get person's ID using login credentials */
CREATE PROCEDURE getIdPersoana
    @email NVARCHAR(100),
    @parola NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT IdPresoana
    FROM Persoana
    WHERE Email = @email
      AND Parola = @parola;
END
GO

/* Check whether a book is available

   The C# application uses ExecuteNonQuery() and expects:
   0 = unavailable
   1 = available

   Therefore this procedure performs a harmless UPDATE on the
   matching available book so ExecuteNonQuery returns 1.
*/
CREATE PROCEDURE spVerificaDisponibilitate
    @titlu NVARCHAR(150),
    @autor NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT OFF;

    UPDATE Biblioteca
    SET Disponibilitate = Disponibilitate
    WHERE Titlu = @titlu
      AND Autor = @autor
      AND Disponibilitate = 1;
END
GO

/* Information displayed after user login */
CREATE PROCEDURE spInfoPersoana
    @email NVARCHAR(100),
    @parola NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        Nume,
        Prenume
    FROM Persoana
    WHERE Email = @email
      AND Parola = @parola;
END
GO

/* Check login credentials */
CREATE PROCEDURE spExistaPersoana
    @email NVARCHAR(100),
    @parola NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT COUNT(*)
    FROM Persoana
    WHERE Email = @email
      AND Parola = @parola;
END
GO

/*SAMPLE DATA*/

INSERT INTO Persoana
    (Nume, Prenume, Telefon, Email, Parola, DataNasterii, Adresa)
VALUES
    ('Popescu', 'Ana', '0712345678',
     'ana@example.com', 'ana123',
     '2002-05-15', 'Cluj-Napoca'),

    ('Ionescu', 'Mihai', '0723456789',
     'mihai@example.com', 'mihai123',
     '2001-10-20', 'Cluj-Napoca'),

    ('Marinescu', 'Elena', '0734567890',
     'elena@example.com', 'elena123',
     '2003-02-10', 'Brasov');
GO


INSERT INTO Biblioteca
    (Titlu, Autor, Disponibilitate)
VALUES
    ('1984', 'George Orwell', 1),
    ('Pride and Prejudice', 'Jane Austen', 1),
    ('The Great Gatsby', 'F. Scott Fitzgerald', 1),
    ('The Hobbit', 'J.R.R. Tolkien', 1),
    ('Crime and Punishment', 'Fyodor Dostoevsky', 1),
    ('To Kill a Mockingbird', 'Harper Lee', 1);
GO


/*TEST*/

SELECT * FROM Persoana;
SELECT * FROM Biblioteca;
GO