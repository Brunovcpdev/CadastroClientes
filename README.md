📋 CadastroClientes
Sistema completo de gerenciamento de clientes, composto por uma API REST em ASP.NET Core (C#) e um frontend em HTML/Bootstrap integrados ao SQL Server via Stored Procedures.

🚀 Tecnologias Utilizadas

.NET / ASP.NET Core — Backend
C# — Lógica da API
SQL Server — Banco de dados
Stored Procedures — Acesso aos dados
HTML + Bootstrap 3 + jQuery — Frontend
Microsoft.Data.SqlClient
Newtonsoft.Json


📁 Estrutura do Projeto
CadastroClientes/
├── Controllers/
│   └── ClientesController.cs     # Endpoints da API
├── Models/
│   ├── Clientes.cs               # Modelo de dados
│   └── Repository/
│       ├── AppConnection.cs      # Configuração de conexão
│       └── ClientesRepository.cs # Acesso ao banco de dados
├── BancoDados/                   # Scripts SQL
├── Properties/
├── SistemaCorporativo.html       # Interface do usuário (Frontend)
├── appsettings.example.json      # Exemplo de configuração
└── Program.cs

🖥️ Interface
O frontend (SistemaCorporativo.html) oferece:

Listagem de todos os clientes cadastrados em tabela
Cadastro de novo cliente via modal
Edição de cliente existente
Exclusão de cliente
Validação dos campos obrigatórios (Documento e Nome)


⚙️ Configuração

Clone o repositório:

bash   git clone https://github.com/Brunovcpdev/CadastroClientes.git

Copie o arquivo de exemplo e preencha com suas configurações:

bash   cp appsettings.example.json appsettings.json

Edite o appsettings.json com sua string de conexão:

json   {
     "ConnectionStrings": {
       "ConnString": "Data Source=SEU_SERVIDOR;Initial Catalog=SEU_BANCO;Integrated Security=True;Encrypt=false;TrustServerCertificate=True;"
     }
   }

Execute as Stored Procedures do SQL Server localizadas na pasta BancoDados/.
Rode a API:

bash   dotnet run

Abra o arquivo SistemaCorporativo.html no navegador.


📌 Endpoints da API
MétodoRotaDescriçãoPOST/api/Clientes/SalvarCria ou atualiza um clientePOST/api/Clientes/AlterarAtualiza um cliente existenteGET/api/Clientes/ListarLista todos os clientesGET/api/Clientes/GetCliente?IdCliente={id}Busca um cliente pelo IDDELETE/api/Clientes/Deletar?IdCliente={id}Remove um cliente pelo ID

🗃️ Stored Procedures Necessárias
ProcedureDescriçãoPROC_INSERIR_CLIENTESInsere um novo clientePROC_UPDATE_CLIENTESAtualiza um cliente existentePROC_LISTAR_CLIENTESLista todos os clientesPROC_GET_CLIENTEBusca cliente por IDPROC_DELETAR_CLIENTESDeleta cliente por ID

👤 Autor
Bruno Vinicius — @Brunovcpdev
