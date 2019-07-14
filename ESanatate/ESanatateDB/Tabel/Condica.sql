CREATE TABLE [dbo].[Condica]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdMedici] INT NOT NULL, 
    [IdAsistenti] INT NOT NULL, 
    [Ore] TIME NOT NULL, 
    [IdTratamente] INT NOT NULL, 
    [IdPacienti] INT NOT NULL, 
    [Data] DATETIME NOT NULL, 
    CONSTRAINT [FK_Condica_Medici] FOREIGN KEY ([IdMedici]) REFERENCES [Medici]([Id]), 
    CONSTRAINT [FK_Condica_Asistenti] FOREIGN KEY ([IdAsistenti]) REFERENCES [Asistenti]([Id]), 
    CONSTRAINT [FK_Condica_Pacienti] FOREIGN KEY ([IdPacienti]) REFERENCES [Pacienti]([Id]), 
    CONSTRAINT [FK_Condica_Tratamente] FOREIGN KEY ([IdTratamente]) REFERENCES [Tratamente]([Id])
)
