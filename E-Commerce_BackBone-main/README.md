# E-Commerce Backbone (.NET 10 Clean Architecture)

A professional, cloud-ready backend API built with the latest **.NET 10** features. This project serves as a robust foundation for e-commerce platforms, emphasizing separation of concerns and scalability.

## 🏗️ Architecture & Technical Stack
This project follows **Clean Architecture** principles to ensure the business logic remains independent of external frameworks.

* **API Layer:** Minimal APIs using .NET 10 for high-performance request handling.
* **Application Layer:** Contains business logic and interfaces.
* **Domain Layer:** Core entities and domain-driven design principles.
* **Infrastructure Layer:** Data persistence via **Entity Framework Core** and **SQLite** (Local) / **Azure SQL** (Cloud).



## 🚀 Key Features
* **Modern Documentation:** Integrated **Scalar UI** for interactive API testing.
* **Cloud-Ready:** Pre-configured for **Azure Key Vault** to manage connection strings securely.
* **High Performance:** Built using **.NET 10 Web SDK** and optimized for future-proof scalability.
* **Validation:** Implementation of industry-standard DataAnnotations for robust data integrity.

## 🛠️ Getting Started
1. Clone the repository.
2. Run `dotnet restore` to install dependencies.
3. Run `dotnet ef database update --project Ecommerce.Infrastructure --startup-project Ecommerce.Api` to initialize the SQLite database.
4. Execute `dotnet run --project Ecommerce.Api` and navigate to `http://localhost:5008/scalar/v1`.

---
*Created by Thato Thamsanqa Mabena - Final Year BSc IT Student at North-West University*