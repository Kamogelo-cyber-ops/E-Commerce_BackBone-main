# E-Commerce Backbone (.NET 10 Clean Architecture)

A cloud-ready backend API for e-commerce platforms, built with **.NET 10** and structured around Clean Architecture principles to keep business logic independent of external frameworks.

> Team project — built collaboratively as part of coursework at North-West University. I contributed as part of the development team.

## 🏗️ Architecture & Technical Stack

This project follows **Clean Architecture**, split into four layers:

- **API Layer** — Minimal APIs using .NET 10 for high-performance request handling
- **Application Layer** — Business logic and interfaces
- **Domain Layer** — Core entities and domain-driven design principles
- **Infrastructure Layer** — Data persistence via **Entity Framework Core**, with **SQLite** locally and **Azure SQL** in the cloud

## 🚀 Key Features

- **Interactive API docs** via Scalar UI
- **Cloud-ready** — pre-configured for Azure Key Vault to manage connection strings securely
- Built on the **.NET 10 Web SDK**
- Validation via industry-standard DataAnnotations

## 🛠️ Getting Started

```bash
# 1. Clone the repository
git clone https://github.com/Kamogelo-cyber-ops/E-Commerce-BackBone.git
cd E-Commerce-BackBone

# 2. Restore dependencies
dotnet restore

# 3. Initialize the SQLite database
dotnet ef database update --project Ecommerce.Infrastructure --startup-project Ecommerce.Api

# 4. Run the API
dotnet run --project Ecommerce.Api
# Navigate to http://localhost:5008/scalar/v1
```

## 📁 Project Structure

```
Ecommerce.Api/             # Minimal API endpoints, startup config
Ecommerce.Application/     # Business logic, interfaces
Ecommerce.Domain/          # Entities, repository interfaces
Ecommerce.Infrastructure/  # EF Core, migrations, repository implementations
```

## 👥 Contributors

- Thato Thamsanqa Mabena
- Kamogelo Komane

---
*Final year BSc IT project at North-West University.*
