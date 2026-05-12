GO

CREATE PROCEDURE PROC_LISTAR_CLIENTES

AS

SELECT IdCliente, Documento, Nome, Sexo, Email, Telefone, Fax, UF 
FROM Clientes
