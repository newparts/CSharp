CREATE TABLE [dbo].[Tratamente]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdPacienti] INT NOT NULL, 
    [IdMedici] INT NOT NULL, 
    [IdAsistenti] INT NOT NULL, 
    [Materiale] NVARCHAR(50) NOT NULL, 
    [Cantitate] NVARCHAR(50) NOT NULL, 
    [Pret] MONEY NOT NULL, 
    [Servicii] NVARCHAR(50) NOT NULL, 
    [IdLaborator] INT NOT NULL, 
    CONSTRAINT [FK_Tratamente_Pacienti] FOREIGN KEY ([IdPacienti]) REFERENCES [Pacienti]([Id]), 
    CONSTRAINT [FK_Tratamente_Medici] FOREIGN KEY ([IdMedici]) REFERENCES [Medici]([Id]), 
    CONSTRAINT [FK_Tratamente_Asistenti] FOREIGN KEY ([IdAsistenti]) REFERENCES [Asistenti]([Id]), 
    CONSTRAINT [FK_Tratamente_Laborator] FOREIGN KEY ([IdLaborator]) REFERENCES [Laborator]([Id])
)
