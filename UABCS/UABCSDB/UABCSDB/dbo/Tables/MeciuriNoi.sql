CREATE TABLE [dbo].[MeciuriNoi] (
    [Id]               INT NOT NULL,
    [MeciuriId]        INT NOT NULL,
    [MeciParinteId]    INT NOT NULL,
    [EchipaInscrisaId] INT NOT NULL,
    [Scor]             INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_MeciuriNoi_Echipe] FOREIGN KEY ([EchipaInscrisaId]) REFERENCES [dbo].[Echipe] ([Id])
);

