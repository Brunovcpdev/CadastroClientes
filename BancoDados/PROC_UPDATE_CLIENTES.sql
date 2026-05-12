use Corporativo

go

CREATE PROCEDURE PROC_UPDATE_CLIENTES
(
	@IdCliente INT,
	@Documento VARCHAR(15),
	@Nome VARCHAR(100),
	@Sexo VARCHAR(1),
	@Email VARCHAR(100),
	@Telefone VARCHAR(11),
	@Fax VARCHAR(11),
	@UF VARCHAR(2)
)

AS

BEGIN
		
		UPDATE Clientes SET Documento = @Documento, Nome = @Nome, Sexo = @Sexo, Email = @Email, Telefone = @Telefone, Fax = @Fax, UF = @UF WHERE IdCliente = @IdCliente

END