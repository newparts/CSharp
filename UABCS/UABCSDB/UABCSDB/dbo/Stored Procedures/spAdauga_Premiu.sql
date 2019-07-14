CREATE PROCEDURE [dbo].[spAdauga_Premiu]
	@NumarLoc int,
	@NumeLoc nvarchar(50),
	@ValoarePremiu money,
	@ProcentPremiu float,
	@id int = 0 output
AS
	Begin
	SET NOCOUNT ON;
	insert into dbo.Premii (NumarLoc, NumeLoc, ValoarePremiu, ProcentPremiu)
	values (@NumarLoc, @NumeLoc, @ValoarePremiu, @ProcentPremiu);

	select @id = SCOPE_IDENTITY();
	End