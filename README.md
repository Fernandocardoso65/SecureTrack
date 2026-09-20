# SecureTrack API

REST API desenvolvida em ASP.NET Core para gerenciamento de incidentes de segurança da informação.

Projeto com foco em estudos para desenvolvimento backend, APIs REST, persistência de dados, validação de entrada e códigos HTTP.

## Tecnologias

- C#
- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- SQLite
- Swagger / OpenAPI
- REST
- JSON

## Funcionalidades

- Cadastro de incidentes
- Consulta de incidentes
- Consulta por ID
- Atualização de incidentes
- Exclusão de incidentes
- Validação automática dos dados recebidos
- Persistência utilizando SQLite
- Documentação através do Swagger
- Testes utilizando cURL

## Severidades

- Low
- Medium
- High
- Critical

## Status

- Open
- InProgress
- Resolved

## Endpoints

| Método | Endpoint | Descrição |
|---|---|---|
| GET | `/api/Incidents` | Lista todos os incidentes |
| GET | `/api/Incidents/{id}` | Consulta um incidente |
| POST | `/api/Incidents` | Cria um incidente |
| PUT | `/api/Incidents/{id}` | Atualiza um incidente |
| DELETE | `/api/Incidents/{id}` | Exclui um incidente |

## Exemplo de criação

```json
{
  "title": "Suspicious login attempt",
  "description": "Multiple failed login attempts detected from an unknown IP address.",
  "category": "Authentication",
  "severity": "High",
  "status": "Open"
}
