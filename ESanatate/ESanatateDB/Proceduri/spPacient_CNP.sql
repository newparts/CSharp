CREATE PROCEDURE [dbo].[Pacient_CNP]
	@CNP nvarchar(50) 
	as
	begin
	select [Id], [Nume], [Prenume], [CNP], [SerieCI], [NumarCI], [Telefon], [Email], 
	[Adresa], [Localitate], [Judet], [Tara], [CodPostal], [Card Sanatate] 
	from dbo.Pacienti 
	where CNP = @CNP;
	end