CREATE TABLE [dbo].[Premii] (
    [Id]            INT           NOT NULL IDENTITY,
    [NumarLoc]      INT           NOT NULL,
    [NumeLoc]       NVARCHAR (50) NOT NULL,
    [ValoarePremiu] MONEY         NOT NULL,
    [ProcentPremiu] FLOAT (53)    NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

