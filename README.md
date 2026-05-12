# 📋 CadastroClientes

Sistema completo de gerenciamento de clientes, composto por uma **API REST em ASP.NET Core (C#)** e um **frontend em HTML/Bootstrap** integrados ao **SQL Server** via Stored Procedures.

---

## 🚀 Tecnologias Utilizadas

- [.NET / ASP.NET Core](https://dotnet.microsoft.com/) — Backend
- C# — Lógica da API
- SQL Server — Banco de dados
- Stored Procedures — Acesso aos dados
- HTML + Bootstrap 3 + jQuery — Frontend
- Microsoft.Data.SqlClient
- Newtonsoft.Json

---

## 📁 Estrutura do Projeto

```
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
```

---

## 🖥️ Interface

O frontend (`SistemaCorporativo.html`) oferece:

- Listagem de todos os clientes cadastrados em tabela
- Cadastro de novo cliente via modal
- Edição de cliente existente
- Exclusão de cliente
- Validação dos campos obrigatórios (Documento e Nome)

---

## ⚙️ Configuração

1. Clone o repositório:
   ```bash
   git clone https://github.com/Brunovcpdev/CadastroClientes.git
   ```

2. Copie o arquivo de exemplo e preencha com suas configurações:
   ```bash
   cp appsettings.example.json appsettings.json
   ```

3. Edite o `appsettings.json` com sua string de conexão:
   ```json
   {
     "ConnectionStrings": {
       "ConnString": "Data Source=SEU_SERVIDOR;Initial Catalog=SEU_BANCO;Integrated Security=True;Encrypt=false;TrustServerCertificate=True;"
     }
   }
   ```

4. Execute as Stored Procedures do SQL Server localizadas na pasta `BancoDados/`.

5. Rode a API:
   ```bash
   dotnet run
   ```

6. Abra o arquivo `SistemaCorporativo.html` no navegador.

---

## 📌 Endpoints da API

| Método | Rota | Descrição |
|--------|------|-----------|
| `POST` | `/api/Clientes/Salvar` | Cria ou atualiza um cliente |
| `POST` | `/api/Clientes/Alterar` | Atualiza um cliente existente |
| `GET` | `/api/Clientes/Listar` | Lista todos os clientes |
| `GET` | `/api/Clientes/GetCliente?IdCliente={id}` | Busca um cliente pelo ID |
| `DELETE` | `/api/Clientes/Deletar?IdCliente={id}` | Remove um cliente pelo ID |

---

## 🗃️ Stored Procedures Necessárias

| Procedure | Descrição |
|-----------|-----------|
| `PROC_INSERIR_CLIENTES` | Insere um novo cliente |
| `PROC_UPDATE_CLIENTES` | Atualiza um cliente existente |
| `PROC_LISTAR_CLIENTES` | Lista todos os clientes |
| `PROC_GET_CLIENTE` | Busca cliente por ID |
| `PROC_DELETAR_CLIENTES` | Deleta cliente por ID |

---

## 👤 Autor

**Bruno Vinicius** — [@Brunovcpdev](https://github.com/Brunovcpdev)
