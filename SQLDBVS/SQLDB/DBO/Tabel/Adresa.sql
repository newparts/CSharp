CREATE TABLE [dbo].[Adresa]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PersoanaId] INT NOT NULL, 
    [Strada] NVARCHAR(50) NOT NULL, 
    [Oras] NVARCHAR(50) NOT NULL, 
    [Judet] NVARCHAR(50) NOT NULL, 
    [CodPostal] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_Adresa_Persoana] FOREIGN KEY ([PersoanaId]) REFERENCES [Persoana]([Id])
)
