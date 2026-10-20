# Ultracar API

API para gerenciamento de orçamentos, veículos, diagnósticos e serviços de oficina, desenvolvida em .NET 10 com PostgreSQL.

## Tecnologias

- .NET 10
- ASP.NET Core Web API
- Entity Framework Core
- PostgreSQL
- Docker e Docker Compose

## Pré-requisitos

Para executar localmente:

- .NET SDK 10
- PostgreSQL em execução

Para executar com containers:

- Docker Desktop com Docker Compose

## Executando com Docker Compose

Abra um terminal na pasta `Ultracar.WebApi` e execute:

```powershell
docker compose up --build
```

A API ficará disponível em:

- http://localhost:5000
- Swagger: http://localhost:5000/swagger

O PostgreSQL será iniciado com as seguintes configurações definidas no `docker-compose.yml`:

| Configuração | Valor |
| --- | --- |
| Host | postgres |
| Porta | 5432 |
| Banco | ultracar_db |
| Usuário | ultracar |
| Senha | ultracar123 |

Para executar os containers em segundo plano:

```powershell
docker compose up --build -d
```

Para visualizar os logs:

```powershell
docker compose logs -f api
```

Para parar os containers:

```powershell
docker compose down
```

Para parar os containers e remover também os dados persistidos do PostgreSQL:

```powershell
docker compose down -v
```

## Executando sem Docker

Na pasta `Ultracar.WebApi`, restaure as dependências e execute a aplicação:

```powershell
dotnet restore
dotnet run --project Ultracar.API/Ultracar.API.csproj
```

Nesse modo, o PostgreSQL precisa estar disponível em `localhost:5432` com as credenciais configuradas em `Ultracar.API/appsettings.json`.

URLs usadas pelo perfil local:

- HTTP: http://localhost:5244
- HTTPS: https://localhost:7148
- Swagger: http://localhost:5244/swagger

## Testes

Para executar os testes:

```powershell
dotnet test
```

## Principais endpoints

Os endpoints estão organizados principalmente nos seguintes grupos:

- `public/v1/orcamentos` — consulta e decisão de orçamento pelo cliente
- `api/oficina/{placa}` — consulta de veículo por placa
- `api/oficina/diagnosticos` — consulta de diagnósticos
- `/api/v1/orcamentos/{id}` — consulta e operações relacionadas ao orçamento
- `/api/v1/orcamentos/{id}/itens` — atualização dos itens do orçamento
- `/api/v1/orcamentos/{id}/historico` — consulta do histórico do orçamento

Consulte o Swagger para visualizar os parâmetros e os modelos de cada operação.

## Estrutura da solução

- `Ultracar.API` — camada HTTP, controllers e configuração da aplicação
- `Ultracar.Application` — serviços, interfaces e DTOs
- `Ultracar.Domain` — entidades e regras do domínio
- `Ultracar.Infrastructure` — acesso a dados e integração com PostgreSQL
- `Ultracar.Testes` — projeto de testes automatizados
