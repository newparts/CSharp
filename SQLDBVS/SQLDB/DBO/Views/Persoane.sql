CREATE VIEW [dbo].[Persoane]
as
	select [p].[Id] as PersoanaId, [p].[Nume], [p].[Prenume], 
	[a].[Id] as AdresaId, [a].[Strada], [a].[Oras], [a].[Judet], [a].[CodPostal]
	from dbo.Persoana p
	left join dbo.Adresa a on p.Id = a.PersoanaId
