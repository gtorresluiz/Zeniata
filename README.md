# 🧘‍♂️ Zeniata WorkHealth API

A **Zeniata WorkHealth API** é uma aplicação desenvolvida em **C# (.NET 8)** utilizando **ASP.NET Core Web API**, conectada a um banco de dados **Oracle**.
O sistema permite o gerenciamento completo de **colaboradores (Workers)**, oferecendo operações de CRUD a partir de uma arquitetura sólida e escalável — incluindo **versionamento oficial da API (API Versioning)**.

---

## 👥 Integrantes

- **Eduardo Fedeli Souza** — RM550132  
- **Gabriel Torres Luiz** — RM98600  
- **Otávio Vitoriano Da Silva** — RM552012  

---

## 🚀 Tecnologias Utilizadas

- **C# 12**  
- **.NET 8 (ASP.NET Core Web API)**  
- **Entity Framework Core 8**  
- **Oracle Database** (via `Oracle.EntityFrameworkCore`)**
- **Swagger (Swashbuckle) com tema customizado e logotipo próprio**
- **API Versioning (Microsoft.AspNetCore.Mvc.Versioning)**
- **CORS liberado para testes e consumo via Postman**

---

## 🧩 Versionamento da API (API Versioning)

A Zeniata API utiliza versionamento oficial, permitindo evolução contínua sem quebras para clientes antigos.

### ✔ Versão atual: v1
Endpoints seguem o padrão:
- **/api/v1/workers**  
- **/api/v1/workers/{id}**

### 📌 Arquitetura pronta para futuras versões:
Endpoints seguem o padrão:
- **/api/v2/workers**  
- **/api/v3/workers**

### O versionamento é configurado no Program.cs:
```csharp
builder.Services.AddApiVersioning(options =>
{
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.ReportApiVersions = true;
});

```

## 🧱 Estrutura do Projeto

### 📦 Zeniata
### ┣ 📂 Controllers → Endpoints (WorkersController)
### ┣ 📂 Data → DbContext + Mapeamentos
### ┣ 📂 Models → Entidades (Worker)
### ┣ 📂 wwwroot
### ┃ ┣ 📂 img → Logotipo (zeniata.jpg)
### ┃ ┗ 📂 swagger-ui → custom.css
### ┣ 📜 Program.cs → Configurações principais
### ┗ 📜 README.md

## 🔌 Conexão com o Banco de Dados Oracle

A conexão está armazenada no **appsettings.json**, carregada no Program:

```csharp
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("OracleConnection"))
);

```

## 🎯 Endpoints da API

| Método | Endpoint               | Descrição                         |
| ------ | ---------------------- | --------------------------------- |
| GET    | `/api/v1/workers`      | Retorna todos os colaboradores    |
| GET    | `/api/v1/workers/{id}` | Retorna um colaborador específico |
| POST   | `/api/v1/workers`      | Cadastra um colaborador           |
| PUT    | `/api/v1/workers/{id}` | Atualiza dados de um colaborador  |
| DELETE | `/api/v1/workers/{id}` | Remove um colaborador             |

### 🧩 Exemplos JSON
- POST
```json
  {
      "id": 0,
      "nome": "teste",
      "email": "gabriel@email.com",
      "cidade": "São Paulo",
      "distanciaMatriz": 0,
      "estiloTrabalho": "Híbrido",
      "cargo": "Diretor",
      "setor": "Machine Learning",
      "statusSaude": "Ativo",
      "dataAdmissao": "2025-11-13T00:00:00",
      "observacoes": "Consegue conciliar a rotina de trabalho com a vida da família e convivio com os parentes"
  }
```
- PUT
```json
  {
      "id": 0,
      "nome": "teste 123",
      "email": "gabriel@email.com",
      "cidade": "São Paulo",
      "distanciaMatriz": 100,
      "estiloTrabalho": "Híbrido",
      "cargo": "Diretor",
      "setor": "Machine Learning",
      "statusSaude": "Ativo",
      "dataAdmissao": "2025-11-13T00:00:00",
      "observacoes": "Consegue conciliar a rotina de trabalho com a vida da família e convivio com os parentes"
  }
```

## ⚡ Como Executar o Projeto

Clonar o repositório
git clone https://github.com/seuusuario/Zeniata.git

Abrir no Visual Studio / VS Code

Restaurar os pacotes NuGet
dotnet restore

Executar a aplicação
dotnet run

Acessar o Swagger
http://localhost:51833/

## 🏫 Projeto Acadêmico

Desenvolvido para FIAP — Engenharia de Software, aplicando:

- Desenvolvimento Web API com .NET 8
- Integração Oracle + Entity Framework Core 
- Boas práticas de arquitetura
- Versionamento de API
- Documentação e testes via Swagger/Postman

