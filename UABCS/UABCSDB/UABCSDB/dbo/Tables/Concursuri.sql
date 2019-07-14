CREATE TABLE [dbo].[Concursuri] (
    [Id]              INT           NOT NULL,
    [NumeConcurs]     NVARCHAR (50) NOT NULL,
    [TaxaParticipare] MONEY         NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

