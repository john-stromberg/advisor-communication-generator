# Advisor Communication Generator

Workflow-oriented advisor tool for drafting plain-English client updates using market and portfolio context.

## Stack
- .NET 10 ASP.NET Core Web API
- Lightweight web UI

## MVP Features
- Configurable communication tone (Reassuring, Balanced, Direct)
- Portfolio vs benchmark context lines
- Market-summary and action-context integration
- Compliance notes + informational disclaimer language

## Run
```bash
dotnet restore advisor-communication-generator.slnx
dotnet run --project src/AdvisorCommunicationGenerator.Api/AdvisorCommunicationGenerator.Api.csproj
```

Open:
- `/` for UI
- `POST /api/communication/generate` for API
