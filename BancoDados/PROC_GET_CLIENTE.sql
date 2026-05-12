GO

CREATE PROCEDURE PROC_GET_CLIENTE
(
	@IdCliente INT
)

AS

SELECT IdCliente, Documento, Nome, Sexo, Email, Telefone, Fax, UF 
FROM Clientes
WHERE IdCliente = @IdCliente
