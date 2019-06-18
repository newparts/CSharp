CREATE TABLE [dbo].[Facturi]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SerieFactura] NVARCHAR(50) NOT NULL, 
    [NumarFactura] INT NOT NULL, 
    [Data] DATE NOT NULL, 
    [Scadenta] DATE NOT NULL, 
    [Valoare] MONEY NOT NULL, 
    [FurnizorID] INT NOT NULL
)
