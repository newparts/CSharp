CREATE TABLE [dbo].[Radiografii]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdPacienti] INT NOT NULL, 
    [IdLaborator] INT NOT NULL, 
    [Radiografie] IMAGE NOT NULL, 
    [Diagnostic] NVARCHAR(50) NOT NULL, 
    [Comentarii] NVARCHAR(MAX) NOT NULL, 
    [Data] DATETIME NOT NULL, 
    [IdCNP] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_Radiografii_Laborator] FOREIGN KEY ([IdLaborator]) REFERENCES [Laborator]([Id]), 
    CONSTRAINT [FK_Radiografii_Pacienti] FOREIGN KEY ([IdPacienti]) REFERENCES [Pacienti]([Id])
)
