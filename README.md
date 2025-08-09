# 📊 Promessômetro (.NET)

**Backend in C# (.NET 8)** built with **Domain-Driven Design (DDD)** architecture to monitor public information requests and promises in São José dos Campos, Brazil.

---

## 📌 Overview

The **Promessômetro** project aims to:

- 🏛 **Track City Council Data** – Collect and publish statistics about information requests (requerimentos) submitted to the São José dos Campos City Council, including:
  - ✅ Approved requests
  - ❌ Rejected requests
  - 📉 How many times each councilor voted *against* a request
- 📈 **Track City Hall Promises** – Compile the promises made by the City Hall and calculate the percentage of fulfillment for each one.

---

## 🏗 Project Architecture

The repository follows a **DDD (Domain-Driven Design)** structure:
```
Promessometro.sln
├── Promessometro.Apresentacao.Api.Docker → Docker container configuration
├── Promessometro.Servico.Requerimentos → Worker service for data collection via scraping
├── Promessometro.Aplicacao → Application logic
├── Promessometro.Dominio → Domain entities and business rules
├── Promessometro.Infraestrutura → Persistence layer with EF
├── Promessometro.WebScraping → Web scraping logic to fetch official data
```
## ⚙ Features by Layer

### 🌐 API Layer (Presentation)
- REST API to retrieve promises and council request data.
- Endpoints for:
  - Approved/rejected requests
  - Votes against requests by each councilor
  - Fulfillment percentage for city hall promises

### 🛠 Worker Layer (Background Service)
- Scheduled job that scrapes official sources daily.
- Updates database with the latest council requests and voting stats.
- Future improvements:
  - Better `appSettings` configuration
  - Deployment and scheduling via Docker/CRON

### 📦 Application, Domain & Infrastructure Layers
- **Application** → Business logic coordination  
- **Domain** → Entities (`Vereador`, `Requerimento`, `Promessa`, etc.) and core rules  
- **Infrastructure** → EF Core persistence, data access, and configuration

---

## 🚀 How to Run (Basic Steps)

1. **Clone the repository**  
   ```bash
   git clone https://github.com/silas-bovolin/PromessometroDotNet.git
Open the solution in Visual Studio or run from CLI with .NET 8.

Configure your appSettings.json with scraping sources and DB connection.

Run the scraping service and test API endpoints with Postman, curl, or browser.

🔗 API Endpoints
```
GET /requerimentos	        List of requests, filterable by status (approved/rejected)
GET /vereadores/{id}/votos  Number of votes against made by a specific councilor
GET /promessas	            List of promises with fulfillment percentage
GET /promessas/{id}	        Detailed information about a single promise
```

🧪 Unit and integration tests

📅 Automated data collection scheduling
