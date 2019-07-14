CREATE TABLE [dbo].[PremiiConcurs] (
    [Id]           INT NOT NULL IDENTITY,
    [ConcursuriId] INT NOT NULL,
    [PremiiId]     INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_PremiiConcurs_Premii] FOREIGN KEY ([PremiiId]) REFERENCES [dbo].[Premii] ([Id])
);

