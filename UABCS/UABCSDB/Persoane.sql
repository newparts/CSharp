CREATE TABLE [dbo].[Persoane]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Nume] NVARCHAR(50) NOT NULL, 
    [Prenume ] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [Telefon] NCHAR(10) NOT NULL
)
