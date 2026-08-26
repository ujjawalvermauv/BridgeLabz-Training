# Backend Refresher Training

This repository contains my Backend Refresher Training work at BridgeLabz.

## Branch Name

`Refresher-Training`

---

# Day-wise Progress

## Day 1 â€” 31-07-2026

### Topics Covered

- Introduction to DBMS
- RDBMS
- Relational vs Non-Relational Database
- SQL Basics
- DDL Commands
- DML Commands
- Creating Database
- Creating Tables
- Primary Key
- Foreign Key
- Constraints
- ER Diagram
- One-to-One Relationship
- One-to-Many Relationship
- Many-to-Many Relationship
- SQL Joins
  - Inner Join
  - Left Join
  - Right Join
  - Full Join
  - Cross Join
  - Self Join

- Pivot Table
- SQL Queries Practice

### Assignments / Programs

- Database Creation
- Table Creation
- ER Diagram Practice
- Patient-Doctor Database
- Foreign Key Implementation
- Join Queries Practice
- Pivot Table Practice

### Project

**RDBMS / SQL Fundamentals**

### Progress

- âœ… Day 1 Completed

---

## Day 2 â€” 03-08-2026

### Topics Covered

- ER Diagram Extension
- Rooms Table
- Doctor_Room Relationship
- Many-to-Many Relationship
- Indexing
  - Single Column Index
  - Composite Index
  - Covering Index

- Query Execution Plan
- Normalization
  - 1NF
  - 2NF
  - 3NF

- Patient_Phones Table

### Assignments / Programs

- Extended Health Clinic Database
- Created Rooms Table
- Implemented Doctor_Room Relationship
- Created Patient_Phones Table
- Created Single Column Index
- Created Composite Index
- Created Covering Index
- Verified Normalization
- Updated ER Diagram

### Project

**ER Diagram, Indexing & Normalization**

### Progress

- âœ… Day 2 Completed

---

## Day 3 â€” 04-08-2026

### Topics Covered

- SQL Joins
  - Inner Join
  - Left Join
  - Right Join
  - Full Outer Join
  - Cross Join
  - Self Join

- Stored Procedures
  - INSERT Stored Procedure
  - UPDATE Stored Procedure
  - DELETE Stored Procedure

- Triggers
  - AFTER INSERT Trigger
  - AFTER UPDATE Trigger
  - AFTER DELETE Trigger

- Audit Table
- Logical Tables
  - `inserted`
  - `deleted`

### Assignments / Programs

- Created Patient_Audit Table
- Implemented AFTER INSERT Trigger
- Implemented AFTER UPDATE Trigger
- Implemented AFTER DELETE Trigger
- Tested Trigger Operations
- Created Doctor INSERT Stored Procedure
- Created Doctor UPDATE Stored Procedure
- Created Doctor DELETE Stored Procedure
- Executed CRUD Operations using Stored Procedures

### Project

**SQL Joins, Stored Procedures & Triggers**

### Progress

- âœ… Day 3 Completed

---

## Day 4 â€” 05-08-2026

### Topics Covered

- ADO.NET
- Connected Architecture
- Disconnected Architecture
- SqlConnection
- SqlCommand
- SqlDataReader
- SqlDataAdapter
- DataTable
- CRUD Operations
- Parameterized Queries
- Exception Handling
- Constructors
- SQL Server Integration

### Project

**Health Clinic Management System**

### Features

- Patient Management (CRUD)
- Doctor Management (CRUD using Stored Procedures)
- Appointment Management (CRUD)
- Room Management (CRUD)
- Connected Architecture using SqlDataReader
- Disconnected Architecture using SqlDataAdapter and DataTable
- Stored Procedures
- SQL Queries
- Trigger Integration
- Exception Handling
- Foreign Key Relationships

### Progress

- âœ… Day 4 Completed

---

## Day 5 â€” 06-08-2026

### Topics Covered

- ASP.NET Core Web API
- Web API Project Structure
- Controllers
- Models
- HTTP Methods
  - GET
  - POST
  - PUT
  - DELETE

- Routing
- `[ApiController]`
- `[Route]`
- `ControllerBase`
- `IActionResult`
- HTTP Status Codes
- JSON Request and Response
- Model Binding
- Dependency Injection Basics
- Swagger / OpenAPI
- API Testing

### Project

**Greeting Web API**

### Features

- Created ASP.NET Core Web API
- Created Greeting Model
- Created Greeting Controller
- Implemented API Endpoints
- Implemented HTTP GET Operation
- Implemented HTTP POST Operation
- Implemented HTTP PUT Operation
- Implemented HTTP DELETE Operation
- Implemented Routing
- Tested APIs using Swagger

### Progress

- âœ… Day 5 Completed

---

## Day 6 â€” 07-08-2026

### Topics Covered

- ASP.NET Core MVC
- MVC Architecture
- Model
- View
- Controller
- Razor Views
- `.cshtml`
- Routing
- Model Binding
- HTTP GET
- HTTP POST
- `IActionResult`
- Form Handling
- View Models
- Static Files
- `wwwroot`
- MVC Project Structure

### Project

**Greeting MVC Application**

### Features

- Created ASP.NET Core MVC Application
- Created Greeting Model
- Created Greeting Controller
- Created Razor View
- Implemented GET Request
- Implemented POST Request
- Implemented Model Binding
- Implemented Greeting Message Generation
- Configured MVC Routing
- Used Razor Syntax
- Used Bootstrap and Static Files

### Progress

- âœ… Day 6 Completed

---

## Day 7 â€” 10-08-2026

### Topics Covered

- ASP.NET Core Minimal API
- Minimal API Project Structure
- Endpoints
- HTTP Methods
  - GET
  - POST
  - PUT
  - DELETE

- Route Parameters
- Request Body
- JSON Response
- Dependency Injection
- SQL Server Integration
- ADO.NET
- Repository Pattern
- CRUD Operations
- Swagger / OpenAPI

### Project

**Contact App**

### Features

- Created ASP.NET Core Minimal API
- Created Contact Model
- Implemented Contact CRUD Operations
- Implemented GET Endpoint
- Implemented POST Endpoint
- Implemented PUT Endpoint
- Implemented DELETE Endpoint
- Integrated SQL Server
- Used ADO.NET
- Used Parameterized Queries
- Tested APIs using Swagger

### Progress

- âœ… Day 7 Completed

---

## Day 8 â€” 11-08-2026

### Topics Covered

- ASP.NET Core Web API
- Repository Pattern
- Service Layer
- Dependency Injection
- SQL Server Integration
- ADO.NET
- `SqlConnection`
- `SqlCommand`
- `SqlDataReader`
- Parameterized Queries
- CRUD Operations
- Swagger / OpenAPI
- Separation of Concerns

### Project

**Contact Management Web API**

### Architecture

```text
Controller
    â†“
Service
    â†“
Repository
    â†“
ADO.NET
    â†“
SQL Server
```

### Features

- Created Contact Management Web API
- Created Contact Model
- Created Repository Interface
- Created Repository Implementation
- Created Service Interface
- Created Service Implementation
- Implemented GET All Contacts
- Implemented GET Contact By ID
- Implemented POST Contact
- Implemented PUT Contact
- Implemented DELETE Contact
- Used ADO.NET for database operations
- Used Parameterized SQL Queries
- Used Dependency Injection
- Tested APIs using Swagger

### Project Structure

```text
Day8-ContactManagement
â”‚
â”œâ”€â”€ Controllers
â”‚   â””â”€â”€ ContactController.cs
â”‚
â”œâ”€â”€ Models
â”‚   â””â”€â”€ Contact.cs
â”‚
â”œâ”€â”€ Repositories
â”‚   â”œâ”€â”€ IContactRepository.cs
â”‚   â””â”€â”€ ContactRepository.cs
â”‚
â”œâ”€â”€ Services
â”‚   â”œâ”€â”€ IContactService.cs
â”‚   â””â”€â”€ ContactService.cs
â”‚
â”œâ”€â”€ Program.cs
â””â”€â”€ appsettings.json
```

### Progress

- âœ… Day 8 Completed

---

## Day 9 â€” 12-08-2026

### Topics Covered

- Entity Framework Core
- ASP.NET Core Web API
- `DbContext`
- `DbSet`
- Entity Models
- Repository Pattern
- Service Layer
- Dependency Injection
- LINQ
- CRUD Operations using Entity Framework Core
- SQL Server Integration
- EF Core Migrations
- Database Creation
- `SaveChanges()`
- Swagger / OpenAPI

### Project

**Entity Contact Web API**

### Architecture

```text
Controller
    â†“
Service
    â†“
Repository
    â†“
DbContext
    â†“
Entity Framework Core
    â†“
SQL Server
```

### Features

- Created ASP.NET Core Web API using Entity Framework Core
- Created Contact Entity Model
- Created `ContactDbContext`
- Configured SQL Server using Entity Framework Core
- Created Repository Interface
- Created Repository Implementation
- Created Service Interface
- Created Service Implementation
- Implemented GET All Contacts
- Implemented GET Contact By ID
- Implemented POST Contact
- Implemented PUT Contact
- Implemented DELETE Contact
- Used LINQ for database operations
- Used `DbSet<Contact>`
- Used `SaveChanges()`
- Created EF Core Migration
- Applied Migration to SQL Server
- Tested APIs using Swagger

### Project Structure

```text
Day9-EntityContact
â”‚
â”œâ”€â”€ Controllers
â”‚   â””â”€â”€ ContactController.cs
â”‚
â”œâ”€â”€ Data
â”‚   â””â”€â”€ ContactDbContext.cs
â”‚
â”œâ”€â”€ Models
â”‚   â””â”€â”€ Contact.cs
â”‚
â”œâ”€â”€ Repositories
â”‚   â”œâ”€â”€ IContactRepository.cs
â”‚   â””â”€â”€ ContactRepository.cs
â”‚
â”œâ”€â”€ Services
â”‚   â”œâ”€â”€ IContactService.cs
â”‚   â””â”€â”€ ContactService.cs
â”‚
â”œâ”€â”€ Migrations
â”‚   â”œâ”€â”€ InitialCreate.cs
â”‚   â”œâ”€â”€ InitialCreate.Designer.cs
â”‚   â””â”€â”€ ContactDbContextModelSnapshot.cs
â”‚
â”œâ”€â”€ Program.cs
â””â”€â”€ appsettings.json
```

### Progress

- âœ… Day 9 Completed

---

## Day 10 â€” 13-08-2026

### Topics Covered

- ASP.NET Core Web API
- Entity Framework Core
- `DbContext`
- `DbSet`
- Repository Pattern
- Service Layer
- Dependency Injection
- LINQ
- SQL Server Integration
- EF Core Migrations
- CRUD Operations
- Swagger / OpenAPI
- Layered Architecture
- Separation of Concerns

### Project

**Address Book Web API**

### Address Book Entity

- Id
- First Name
- Last Name
- Address
- City
- State
- Zip
- Phone
- Email

### Architecture

```text
Controller
    â†“
Service
    â†“
Repository
    â†“
DbContext
    â†“
Entity Framework Core
    â†“
SQL Server
```

### Features

- Created Address Book Web API
- Created Address Entry Model
- Created `AddressBookDbContext`
- Configured SQL Server using Entity Framework Core
- Implemented Repository Pattern
- Implemented Service Layer
- Implemented Dependency Injection
- Implemented GET All Address Entries
- Implemented GET Address Entry By ID
- Implemented POST Address Entry
- Implemented PUT Address Entry
- Implemented DELETE Address Entry
- Used LINQ for database operations
- Used `DbSet<AddressEntry>`
- Used `SaveChanges()`
- Created EF Core Migration
- Created Address Book Database
- Tested APIs using Swagger

### Project Structure

```text
Day10-AddressBookAPI
â”‚
â”œâ”€â”€ Controllers
â”‚   â””â”€â”€ AddressController.cs
â”‚
â”œâ”€â”€ Data
â”‚   â””â”€â”€ AddressBookDbContext.cs
â”‚
â”œâ”€â”€ Models
â”‚   â””â”€â”€ AddressEntry.cs
â”‚
â”œâ”€â”€ Repositories
â”‚   â”œâ”€â”€ IAddressRepository.cs
â”‚   â””â”€â”€ AddressRepository.cs
â”‚
â”œâ”€â”€ Services
â”‚   â”œâ”€â”€ IAddressService.cs
â”‚   â””â”€â”€ AddressService.cs
â”‚
â”œâ”€â”€ Migrations
â”‚
â”œâ”€â”€ Program.cs
â””â”€â”€ appsettings.json
```

### Progress

- âœ… Day 10 Completed

---

---

Day 11 â€” 14-08-2026
Topics Covered
ASP.NET Core Web API

Layered Architecture

Solution with Multiple Projects

API Layer

Models Layer

Repository Layer

Service Layer

Dependency Injection

Interfaces

DTOs

CRUD Operations

Search Operations

Search By State

Search By City

SQL Server Integration

Database Operations

Swagger / OpenAPI

Separation of Concerns

Project
AddressBook

Architecture
AddressBook.API
â†“
AddressBook.Service
â†“
AddressBook.Repository
â†“
AddressBook.Models
â†“
SQL Server / Database
Features
Created AddressBook solution

Created AddressBook.API project

Created AddressBook.Models project

Created AddressBook.Repository project

Created AddressBook.Service project

Implemented layered architecture

Implemented Dependency Injection

Created Models and DTOs

Created Repository Interfaces and Implementations

Created Service Interfaces and Implementations

Implemented Address Book CRUD operations

Implemented Search By State

Implemented Search By City

Integrated SQL Server database

Implemented API endpoints

Tested APIs using Swagger

Address Book Fields
Id

Name

PhoneNumber

Email

Address

City

State

ZipCode

CreatedAt

Project Structure
Day11-AddressBook
â”‚
â”œâ”€â”€ AddressBook.sln
â”‚
â”œâ”€â”€ AddressBook.API
â”‚ â”œâ”€â”€ Controllers
â”‚ â””â”€â”€ Program.cs
â”‚
â”œâ”€â”€ AddressBook.Models
â”‚ â”œâ”€â”€ Models
â”‚ â””â”€â”€ DTOs
â”‚
â”œâ”€â”€ AddressBook.Repository
â”‚ â”œâ”€â”€ Interfaces
â”‚ â””â”€â”€ Repositories
â”‚
â””â”€â”€ AddressBook.Service
â”œâ”€â”€ Interfaces
â””â”€â”€ Services
âœ… Day 11 Completed

Day 12 â€” 17-08-2026
Topics Covered
ASP.NET Core Web API

Entity Framework Core

Code-First Approach

SQL Server Integration

DbContext

DbSet

EF Core Migrations

Layered Architecture

Multiple Project Solution

API Layer

Models Layer

Repository Layer

Service Layer

Dependency Injection

Interfaces

DTOs

BCrypt Password Hashing

User Registration

User Login

JWT Authentication

JWT Token Generation

[Authorize]

Swagger / OpenAPI

Swagger JWT Authorization

Notes CRUD Operations

User-Specific Data using JWT UserId

Repository Pattern

Service Layer

Separation of Concerns

Project
FundooNotes Web API

Architecture
Fundoo.Api
â†“
FundooNotes.Service
â†“
FundooNotes.Repository
â†“
FundooNotes.Models
â†“
Entity Framework Core
â†“
SQL Server
Authentication Flow
Register
â†“
Password Hashing using BCrypt
â†“
SQL Server

Login
â†“
Validate Email & Password
â†“
Generate JWT Token
â†“
Swagger / Client
â†“
[Authorize]
â†“
Notes APIs
Features
Created FundooNotes solution

Created Fundoo.Api project

Created FundooNotes.Models project

Created FundooNotes.Repository project

Created FundooNotes.Service project

Implemented layered architecture

Implemented Dependency Injection

Created User and Note entities

Created DTOs for registration and login

Configured SQL Server using Entity Framework Core

Created FundooDbContext

Created EF Core migration

Applied database migration

Implemented User Registration

Implemented BCrypt password hashing

Implemented User Login

Implemented JWT token generation

Implemented JWT authentication

Implemented [Authorize]

Configured Swagger JWT authorization

Implemented Create Note

Implemented Get All Notes

Implemented Get Note By ID

Implemented Update Note

Implemented Delete Note

Implemented user-specific note access using JWT UserId

Tested APIs using Swagger

Project Structure
Day-12
â”‚
â””â”€â”€ FundooNotes
â”‚
â”œâ”€â”€ FundooNotes.slnx
â”‚
â”œâ”€â”€ Fundoo.Api
â”‚ â”œâ”€â”€ Controllers
â”‚ â”‚ â”œâ”€â”€ NoteController.cs
â”‚ â”‚ â””â”€â”€ UserController.cs
â”‚ â”œâ”€â”€ Program.cs
â”‚ â”œâ”€â”€ appsettings.json
â”‚ â””â”€â”€ appsettings.Development.json
â”‚
â”œâ”€â”€ FundooNotes.Models
â”‚ â”œâ”€â”€ DTOs
â”‚ â”‚ â”œâ”€â”€ LoginRequest.cs
â”‚ â”‚ â”œâ”€â”€ LoginResponse.cs
â”‚ â”‚ â”œâ”€â”€ NoteRequest.cs
â”‚ â”‚ â””â”€â”€ RegisterRequest.cs
â”‚ â””â”€â”€ Entities
â”‚ â”œâ”€â”€ Note.cs
â”‚ â””â”€â”€ User.cs
â”‚
â”œâ”€â”€ FundooNotes.Repository
â”‚ â”œâ”€â”€ Data
â”‚ â”‚ â””â”€â”€ FundooDbContext.cs
â”‚ â”œâ”€â”€ Implementations
â”‚ â”‚ â”œâ”€â”€ NoteRepository.cs
â”‚ â”‚ â””â”€â”€ UserRepository.cs
â”‚ â”œâ”€â”€ Interfaces
â”‚ â”‚ â”œâ”€â”€ INoteRepository.cs
â”‚ â”‚ â””â”€â”€ IUserRepository.cs
â”‚ â””â”€â”€ Migrations
â”‚
â””â”€â”€ FundooNotes.Service
â”œâ”€â”€ Implementations
â”‚ â”œâ”€â”€ NoteService.cs
â”‚ â””â”€â”€ UserService.cs
â””â”€â”€ Interfaces
â”œâ”€â”€ INoteService.cs
â””â”€â”€ IUserService.cs
Progress
âœ… Day 12 Completed

Repository Structure

```text
Refresher-Training
â”‚
â”œâ”€â”€ README.md
â”‚
â”œâ”€â”€ day1-RDBMS
â”œâ”€â”€ day2-ER-Indexing-Normalization
â”œâ”€â”€ Day3-Store-Joins-Trigger
â”œâ”€â”€ day4-HealthClinicApp
â”œâ”€â”€ day5-WebAPI-Project
â”œâ”€â”€ day6-GreetingApp
â”œâ”€â”€ day7-contactapp
â”œâ”€â”€ Day8-ContactManagement
â”œâ”€â”€ Day9-EntityContact
â””â”€â”€ Day10-AddressBookAPI
```

---

# Technology Progress

```text
SQL
 â†“
DBMS / RDBMS
 â†“
ER Diagram
 â†“
Normalization
 â†“
Indexing
 â†“
Stored Procedures
 â†“
Triggers
 â†“
ADO.NET
 â†“
ASP.NET Core Web API
 â†“
ASP.NET Core MVC
 â†“
Minimal API
 â†“
Repository Pattern
 â†“
Service Layer
 â†“
Entity Framework Core
 â†“
EF Core Migrations
 â†“
Layered Web API Architecture
```

---

## Day 13 — 20-08-2026

### Topics Covered
- Layered Architecture Refinement
- ASP.NET Core Web API Extensions
- Data Transfer Objects (DTOs) Refactoring
- Entity Framework Core Migrations

### Project
**FundooNotes Web API**

### Architecture
```text
Fundoo.Api
 ↓
FundooNotes.Service
 ↓
FundooNotes.Repository
 ↓
FundooNotes.Models
```

### Features
- Refined FundooNotes solution structure
- Expanded Note CRUD operations
- Refined User authentication logic
- Stabilized database connections and relationships

### Project Structure
```text
Day-13
│
└── FundooNotes
```

### Progress
✅ Day 13 Completed

---

## Day 14 — 21-08-2026

### Topics Covered
- API Endpoints Optimization
- JWT Authorization Enhancements
- Note Entity Expansion
- Error Handling

### Project
**FundooNotes Web API**

### Architecture
```text
Fundoo.Api
 ↓
FundooNotes.Service
 ↓
FundooNotes.Repository
```

### Features
- Continued refinement of FundooNotes API
- Ensured strict user data isolation using ClaimTypes.NameIdentifier
- Added comprehensive model validation for DTOs
- Optimized EF Core LINQ queries for Note retrieval

### Project Structure
```text
Day-14
│
└── FundooNotes
```

### Progress
✅ Day 14 Completed

---

## Day 15 — 24-08-2026

### Topics Covered
- Note CRUD Operations
- Advanced JWT Authentication & Authorization
- EF Core Migrations
- Swagger UI Configuration
- Repository and Service Layer Pattern

### Project
**FundooNotes Web API**

### Architecture
```text
Fundoo.Api (Controllers, Program.cs)
 ↓
FundooNotes.Service (Interfaces & Implementations)
 ↓
FundooNotes.Repository (DbContext, EF Core)
 ↓
FundooNotes.Models (Entities & DTOs)
```

### Features
- Implemented robust Note CRUD APIs (Create, Read, Update, Delete)
- Implemented JWT authentication and route protection using `[Authorize]`
- Enforced strict data isolation by extracting `UserId` directly from JWT claims
- Added specific Note features like `IsPinned`, `IsArchived`, and `IsTrashed`
- Created and applied EF Core migrations for SQL Server
- Configured Swagger with JWT Bearer token support

### Project Structure
```text
Day-15
│
└── FundooNotes
    ├── Fundoo.Api
    ├── FundooNotes.Models
    ├── FundooNotes.Repository
    └── FundooNotes.Service
```

### Progress
✅ Day 15 Completed

---

## Day 16 — 25-08-2026

### Topics Covered
- Labels and Many-to-Many Relationships
- Unit Testing with MSTest and Moq
- Application Logging with NLog
- Global Exception Handling

### Project
**FundooNotes Web API**

### Architecture
```text
Fundoo.Api (NLog integration)
 ↓
Fundoo.Tests (MSTest + Moq)
 ↓
FundooNotes.Service (LabelService)
 ↓
FundooNotes.Repository (LabelRepository)
```

### Features
- Created `Label` entity and implemented Label CRUD operations
- Established a Many-to-Many relationship between Notes and Labels via a `NoteLabels` join table
- Added APIs to attach and remove labels from notes, and fetch notes by label
- Generated and applied EF Core `AddLabels` migration
- Integrated NLog for structured application logging and file output
- Created comprehensive unit tests using MSTest and Moq (`Fundoo.Tests`)
- Verified test suite executing with 100% pass rate

### Project Structure
```text
Day-16
│
└── FundooNotes
    ├── Fundoo.Api
    ├── Fundoo.Tests
    ├── FundooNotes.Models
    ├── FundooNotes.Repository
    └── FundooNotes.Service
```

### Progress
✅ Day 16 Completed

---

## Day 17 — 26-08-2026

### Topics Covered
- Reminder System Implementation
- Asynchronous Messaging with RabbitMQ
- SMTP Email Integration
- Background Hosted Services

### Project
**FundooNotes Web API**

### Architecture
```text
Fundoo.Api (ReminderController, BackgroundService)
 ↓
FundooNotes.Service (RabbitMQService, SmtpService, ReminderService)
 ↓
FundooNotes.Repository (ReminderRepository)
 ↓
Message Broker (RabbitMQ) & SMTP Server
```

### Features
- Created `Reminder` entity and specialized DTOs linking `User` and `Note`
- Implemented Reminder CRUD operations and API endpoints
- Integrated `RabbitMQ.Client` to publish `ReminderMessage` events to a queue
- Created `ReminderConsumerBackgroundService` as a hosted service to continuously listen to the queue
- Integrated `System.Net.Mail` via `SmtpService` to dispatch email notifications when reminder time is reached
- Added `AddReminders` EF Core migration and applied to SQL Server
- Extended unit testing suite to cover Reminder logic and mock RabbitMQ/SMTP dependencies

### Project Structure
```text
Day-17
│
└── FundooNotes
    ├── Fundoo.Api
    ├── Fundoo.Tests
    ├── FundooNotes.Models
    ├── FundooNotes.Repository
    └── FundooNotes.Service
```

### Progress
✅ Day 17 Completed

---

## Day 18 — 26-08-2026

### Topics Covered
- Distributed Caching with Redis
- StackExchange.Redis Integration
- Cache Invalidation Strategies
- API Performance Optimization

### Project
**FundooNotes Web API**

### Architecture
```text
Fundoo.Api (StackExchange.Redis DI)
 ↓
FundooNotes.Service (CacheService, NoteService)
 ↓
Redis Server (Distributed Cache)
```

### Features
- Configured Redis caching via `StackExchange.Redis`
- Created `ICacheService` and implemented `CacheService` to handle generic JSON serialization and Redis operations
- Added `GetRecentNotesAsync` to fetch the top 5 most recently updated notes
- Created `GET /api/Note/recent` endpoint
- Implemented a 5-minute cache expiry for recent notes retrieval
- Engineered dynamic cache invalidation (cache eviction) immediately following any Note mutation (Create, Update, Delete, Pin, Archive, Trash)
- Injected `IConnectionMultiplexer` as a singleton in `Program.cs` and added connection string to `appsettings.json`
- Wrote robust MSTest unit tests to verify both cache hit (skipping DB) and cache miss (querying DB and setting cache) behaviors
- Test execution passed successfully with 26 total passing tests

### Project Structure
```text
Day-18
│
└── FundooNotes
    ├── Fundoo.Api
    ├── Fundoo.Tests
    ├── FundooNotes.Models
    ├── FundooNotes.Repository
    └── FundooNotes.Service
```

### Progress
✅ Day 18 Completed

---

# Day-wise Progress Summary

| Day    | Date       | Project                                 | Status |
| ------ | ---------- | --------------------------------------- | ------ |
| Day 1  | 31-07-2026 | RDBMS / SQL Fundamentals                | ✅     |
| Day 2  | 03-08-2026 | ER Diagram, Indexing & Normalization    | ✅     |
| Day 3  | 04-08-2026 | SQL Joins, Stored Procedures & Triggers | ✅     |
| Day 4  | 05-08-2026 | Health Clinic Management System         | ✅     |
| Day 5  | 06-08-2026 | Greeting Web API                        | ✅     |
| Day 6  | 07-08-2026 | Greeting MVC Application                | ✅     |
| Day 7  | 10-08-2026 | Contact App - Minimal API               | ✅     |
| Day 8  | 11-08-2026 | Contact Management Web API              | ✅     |
| Day 9  | 12-08-2026 | Entity Contact Web API                  | ✅     |
| Day 10 | 13-08-2026 | Address Book Web API                    | ✅     |
| Day 11 | 14-08-2026 | AddressBook - Layered Web API           | ✅     |
| Day 12 | 17-08-2026 | FundooNotes Web API                     | ✅     |
| Day 13 | 20-08-2026 | FundooNotes Continuation                | ✅     |
| Day 14 | 21-08-2026 | FundooNotes Continuation                | ✅     |
| Day 15 | 24-08-2026 | FundooNotes Features & Authentication   | ✅     |
| Day 16 | 25-08-2026 | FundooNotes Labels & Unit Testing       | ✅     |
| Day 17 | 26-08-2026 | FundooNotes Reminders & RabbitMQ        | ✅     |
| Day 18 | 26-08-2026 | FundooNotes Redis Caching               | ✅     |

---

# Git Commit History

| Date       | Work                                             |
| ---------- | ------------------------------------------------ |
| 31-07-2026 | Day 1 - DBMS Fundamentals & RDBMS Basics         |
| 03-08-2026 | Day 2 - ER Diagram, Indexing & Normalization     |
| 04-08-2026 | Day 3 - SQL Joins, Stored Procedures & Triggers  |
| 05-08-2026 | Day 4 - ADO.NET Health Clinic Management System  |
| 06-08-2026 | Day 5 - ASP.NET Core Web API - Greeting Project  |
| 07-08-2026 | Day 6 - ASP.NET Core MVC - Greeting Application  |
| 10-08-2026 | Day 7 - ASP.NET Core Minimal API - Contact App   |
| 11-08-2026 | Day 8 - Contact Management Web API using ADO.NET |
| 12-08-2026 | Day 9 - Entity Framework Core Contact API        |
| 13-08-2026 | Day 10 - Address Book Web API                    |
| 14-08-2026 | Day 11 - AddressBook Layered Web API             |
| 17-08-2026 | Day 12 - FundooNotes Web API                     |
| 20-08-2026 | Day 13 - FundooNotes Continuation                |
| 21-08-2026 | Day 14 - FundooNotes Continuation                |
| 24-08-2026 | Day 15 - FundooNotes Advanced Features           |
| 25-08-2026 | Day 16 - FundooNotes Labels & Unit Testing       |
| 26-08-2026 | Day 17 - FundooNotes Reminders & RabbitMQ        |
| 26-08-2026 | Day 18 - FundooNotes Redis Caching               |

---

# Current Progress

```text
Day 1   ✅
Day 2   ✅
Day 3   ✅
Day 4   ✅
Day 5   ✅
Day 6   ✅
Day 7   ✅
Day 8   ✅
Day 9   ✅
Day 10  ✅
Day 11  ✅
Day 12  ✅
Day 13  ✅
Day 14  ✅
Day 15  ✅
Day 16  ✅
Day 17  ✅
Day 18  ✅
```

---

## Author

**Ujjawal Verma**
