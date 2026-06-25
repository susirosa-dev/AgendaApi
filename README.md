# AgendaApi

API REST para gerenciamento de contatos desenvolvida em ASP.NET Core Web API, 
como parte dos meus estudos em Desenvolvimento e QA.

## Tecnologias

- ASP.NET Core
- C#
- Entity Framework Core
- MySQL
- Swagger / OpenAPI
- Git
- GitHub

## Funcionalidades

- Listar todos os contatos
- Buscar contato por Id
- Buscar contatos por nome
- Cadastrar contato
- Alterar contato
- Excluir contato

## Endpoints

| Método | Endpoint |
|--------|----------|
| GET | `/api/Contatos` |
| GET | `/api/Contatos/{id}` |
| GET | `/api/Contatos/buscar?nome=Maria` |
| POST | `/api/Contatos` |
| PUT | `/api/Contatos/{id}` |
| DELETE | `/api/Contatos/{id}` |

## Como executar

1. Clonar o repositório
2. Configurar a string de conexão no `appsettings.json`
3. Aplicar as migrations ao banco de dados
4. Iniciar a aplicação
5. Acessar o Swagger

## ✅ Versão Atual (v1.0)

### Funcionalidades implementadas

- CRUD completo de contatos
- ASP.NET Core Web API
- Entity Framework Core 
- Injeção de Dependência
- MySQL
- DTOs
- Validações
- Tratamento de respostas HTTP (200, 201, 400, 404)
- Busca por nome
- Swagger
- Git/GitHub

Este projeto está sendo desenvolvido de forma incremental como parte dos meus estudos 
em Desenvolvimento e QA. A cada nova etapa de aprendizado, novas funcionalidades serão 
incorporadas à API.

## Objetivo do Projeto

Este projeto foi criado para servir como laboratório de estudos em Desenvolvimento e 
Qualidade de Software (QA).

Além de acompanhar minha evolução em ASP.NET Core, a API será expandida continuamente 
para incluir autenticação, autorização, paginação, logs e testes automatizados, 
tornando-se uma plataforma para estudos de APIs REST utilizando ferramentas como Swagger, 
Postman e Rest Assured.

## 🚀 Roadmap

### ✅ V1 - Concluída

- [x] CRUD de Contatos
- [x] MySQL
- [x] Entity Framework Core
- [x] Swagger
- [x] DTOs
- [x] Validações

### 🔜 V2

- [ ] Cadastro de usuários
- [ ] Login
- [ ] Autenticação JWT
- [ ] Autorização por usuário
- [ ] Usuários visualizam apenas seus próprios contatos

### 🔜 V3

- [ ] Paginação
- [ ] Ordenação
- [ ] Logs
- [ ] Tratamento global de exceções

### 🔜 V4

- [ ] Testes automatizados com Rest Assured
- [ ] Coleção Postman
- [ ] Pipeline GitHub Actions
- [ ] Documentação de testes

## Autor

**Susi da Rosa**

Projeto desenvolvido para estudos de ASP.NET Core, APIs REST e Testes de Software (QA).

📌 Este projeto continuará evoluindo conforme meu aprendizado em Desenvolvimento e Qualidade de Software.