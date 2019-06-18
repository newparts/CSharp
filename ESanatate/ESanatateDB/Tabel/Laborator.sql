CREATE TABLE [dbo].[Laborator]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Denumire] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [Telefon] NVARCHAR(50) NOT NULL, 
    [Adresa] NVARCHAR(50) NOT NULL, 
    [CUI] NVARCHAR(50) NOT NULL, 
    [CIF] NVARCHAR(50) NOT NULL, 
    [SerieContract] NVARCHAR(50) NOT NULL, 
    [NumarContract] INT NOT NULL, 
    [Localitate] NVARCHAR(50) NOT NULL, 
    [Judet] NVARCHAR(50) NOT NULL, 
    [Tara] NVARCHAR(50) NOT NULL, 
    [CodPostal] INT NOT NULL
)
