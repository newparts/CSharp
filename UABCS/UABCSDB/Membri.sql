CREATE TABLE [dbo].[Premii]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [NumarLoc] INT NOT NULL, 
    [NumeLoc] NVARCHAR(50) NOT NULL, 
    [ValoarePremiu] MONEY NOT NULL, 
    [ProcentPremiu] FLOAT NOT NULL
)
