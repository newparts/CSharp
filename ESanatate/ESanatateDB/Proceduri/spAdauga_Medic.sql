CREATE PROCEDURE [dbo].[spAdauga_Medic]
	@Nume nvarchar(50),
	@Prenume nvarchar(50),
	@CNP nvarchar(50),
	@SerieCI nvarchar(50),
	@NumarCI int,
	@SerieContract nvarchar(50),
	@NumarContract int,
	@SerieCertificatCM nvarchar(50),
	@NumarCertificatCM int,
	@Utilizator nvarchar(50),
	@Parola nvarchar(50),
	@Telefon nvarchar(50),
	@Email nvarchar(50),
	@Adresa nvarchar(50),
	@Localitate nvarchar(50),
	@Judet nvarchar(50),
	@Tara nvarchar(50),
	@CodPostal int,
	@Specializarea nvarchar(50),
	@id int = 0 output
AS
	BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.Medici (Nume, Prenume, CNP, SerieCI, NumarCI, SerieContract, NumarContract, SerieCertificatCM, NumarCertificatCM, Utilizator, Parola, Email, Telefon, Adresa, Localitate, Judet, Tara, CodPostal, Specializarea)
	VALUES (@Nume, @Prenume, @CNP, @SerieCI, @NumarCI, @SerieContract, @NumarContract, @SerieCertificatCM, @NumarCertificatCM, @Utilizator, @Parola, @Email, @Telefon, @Adresa, @Localitate, @Judet, @Tara, @CodPostal, @Specializarea);

	SELECT @id = SCOPE_IDENTITY();
	END
