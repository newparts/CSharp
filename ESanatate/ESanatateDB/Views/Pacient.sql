CREATE VIEW [dbo].[Pacient]
	AS 
	SELECT [p].[Id] as PacientiId, [p].[Nume], [p].[Prenume], [p].[CNP], [p].[SerieCI], 
	[p].[NumarCI], [p].[Telefon], [p].[Email], [p].[Adresa], [p].[Localitate], 
	[p].[Judet], [p].[Tara], [p].[CodPostal], [p].[Card Sanatate], 
	[r].[Id] as RadiografiiId, [r].[IdPacienti], [r].[IdLaborator], [r].[Radiografie], [r].[Diagnostic], 
	[r].[Comentarii], [r].[Data], [r].[IdCNP]
 FROM dbo.Pacienti p
 left join dbo.Radiografii r on p.Id = r.IdPacienti
