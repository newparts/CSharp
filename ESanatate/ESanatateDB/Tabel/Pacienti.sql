CREATE TABLE [dbo].[Pacienti]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nume] NVARCHAR(50) NOT NULL, 
    [Prenume] NVARCHAR(50) NOT NULL, 
    [CNP] NVARCHAR(50) NOT NULL, 
    [SerieCI] NVARCHAR(50) NOT NULL, 
    [NumarCI] NVARCHAR(50) NOT NULL, 
    [Telefon] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [Adresa] NVARCHAR(50) NOT NULL, 
    [Localitate] NVARCHAR(50) NOT NULL, 
    [Judet] NVARCHAR(50) NOT NULL, 
    [Tara] NVARCHAR(50) NOT NULL, 
    [CodPostal] INT NOT NULL, 
    [Card Sanatate] NVARCHAR(50) NOT NULL, 
    [Utilizator] NVARCHAR(50) NOT NULL, 
    [Parola] NVARCHAR(50) NOT NULL
)
