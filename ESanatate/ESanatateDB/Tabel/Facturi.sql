CREATE TABLE [dbo].[Facturi]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SerieFactura] NVARCHAR(50) NOT NULL, 
    [NumarFactura] INT NOT NULL, 
    [DataEmiterii] DATE NOT NULL, 
    [DataScadentei] DATE NOT NULL, 
    [ValoareNeta] MONEY NOT NULL, 
    [FurnizorID] INT NOT NULL, 
    [CantitateProdus] NVARCHAR(50) NOT NULL, 
    [DenumireProdus] NVARCHAR(50) NOT NULL, 
    [UnitateMasura] NCHAR(10) NOT NULL, 
    [ValoareTotala] MONEY NOT NULL, 
    [PretUnitar] MONEY NOT NULL, 
    [TVA] MONEY NOT NULL 
)
