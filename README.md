# AgendaApi

API REST para gerenciamento de contatos desenvolvida em ASP.NET Core Web API.

## Tecnologias

- ASP.NET Core
- C#
- Entity Framework Core
- MySQL
- Swagger / OpenAPI

## Funcionalidades

- Listar todos os contatos
- Buscar contato por Id
- Buscar contatos por nome
- Cadastrar contato
- Alterar contato
- Excluir contato

## Endpoints

GET /api/Contatos

GET /api/Contatos/{id}

GET /api/Contatos/buscar?nome=Maria

POST /api/Contatos

PUT /api/Contatos/{id}

DELETE /api/Contatos/{id}

## Como executar

1. Clonar o repositório
2. Configurar a string de conexão no `appsettings.json`
3. Executar as migrations
4. Iniciar a aplicação

## Autor

Susi da Rosa