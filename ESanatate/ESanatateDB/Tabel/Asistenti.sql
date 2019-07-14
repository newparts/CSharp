CREATE TABLE [dbo].[Asistenti]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nume] NVARCHAR(50) NOT NULL, 
    [Prenume] NVARCHAR(50) NOT NULL, 
    [CNP] INT NOT NULL, 
    [SerieCI] NVARCHAR(50) NOT NULL, 
    [NumarCI] INT NOT NULL, 
    [SerieContract] NVARCHAR(50) NOT NULL, 
    [NumarContract] INT NOT NULL, 
    [SerieCertificatCA] NVARCHAR(50) NOT NULL, 
    [NumarCertificatCA] INT NOT NULL, 
    [Utilizator] NVARCHAR(50) NOT NULL, 
    [Parola] NVARCHAR(50) NOT NULL, 
    [Telefon] NVARCHAR(50) NOT NULL, 
    [Emal] NVARCHAR(50) NOT NULL, 
    [Adresa] NVARCHAR(50) NOT NULL, 
    [Localitate] NVARCHAR(50) NOT NULL, 
    [Judet] NVARCHAR(50) NOT NULL, 
    [Tara] NVARCHAR(50) NOT NULL, 
    [CodPostal] INT NOT NULL, 
    [Specializarea] NVARCHAR(50) NOT NULL
)
