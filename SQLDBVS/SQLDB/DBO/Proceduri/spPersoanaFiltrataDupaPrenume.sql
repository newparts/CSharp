CREATE PROCEDURE [dbo].[spPersoanaFiltrataDupaPrenume]
	@Prenume nvarchar(50)

	as

	begin
	select [Id], [Nume], [Prenume]
	from dbo.Persoana 
	where Prenume = @Prenume; 
	end
