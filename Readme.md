# Backend Refresher Training

This repository contains my Backend Refresher Training work at BridgeLabz.

## Branch Name

`Refresher-Training`

---

# Day-wise Progress

## Day 1 — 31-07-2026

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

- ✅ Day 1 Completed

---

## Day 2 — 03-08-2026

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

- ✅ Day 2 Completed

---

## Day 3 — 04-08-2026

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

- ✅ Day 3 Completed

---

## Day 4 — 05-08-2026

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

- ✅ Day 4 Completed

---

## Day 5 — 06-08-2026

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

- ✅ Day 5 Completed

---

## Day 6 — 07-08-2026

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

- ✅ Day 6 Completed

---

## Day 7 — 10-08-2026

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

- ✅ Day 7 Completed

---

## Day 8 — 11-08-2026

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
    ↓
Service
    ↓
Repository
    ↓
ADO.NET
    ↓
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
│
├── Controllers
│   └── ContactController.cs
│
├── Models
│   └── Contact.cs
│
├── Repositories
│   ├── IContactRepository.cs
│   └── ContactRepository.cs
│
├── Services
│   ├── IContactService.cs
│   └── ContactService.cs
│
├── Program.cs
└── appsettings.json
```

### Progress

- ✅ Day 8 Completed

---

## Day 9 — 12-08-2026

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
    ↓
Service
    ↓
Repository
    ↓
DbContext
    ↓
Entity Framework Core
    ↓
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
│
├── Controllers
│   └── ContactController.cs
│
├── Data
│   └── ContactDbContext.cs
│
├── Models
│   └── Contact.cs
│
├── Repositories
│   ├── IContactRepository.cs
│   └── ContactRepository.cs
│
├── Services
│   ├── IContactService.cs
│   └── ContactService.cs
│
├── Migrations
│   ├── InitialCreate.cs
│   ├── InitialCreate.Designer.cs
│   └── ContactDbContextModelSnapshot.cs
│
├── Program.cs
└── appsettings.json
```

### Progress

- ✅ Day 9 Completed

---

## Day 10 — 13-08-2026

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
    ↓
Service
    ↓
Repository
    ↓
DbContext
    ↓
Entity Framework Core
    ↓
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
│
├── Controllers
│   └── AddressController.cs
│
├── Data
│   └── AddressBookDbContext.cs
│
├── Models
│   └── AddressEntry.cs
│
├── Repositories
│   ├── IAddressRepository.cs
│   └── AddressRepository.cs
│
├── Services
│   ├── IAddressService.cs
│   └── AddressService.cs
│
├── Migrations
│
├── Program.cs
└── appsettings.json
```

### Progress

- ✅ Day 10 Completed

---

---

Day 11 — 14-08-2026
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
↓
AddressBook.Service
↓
AddressBook.Repository
↓
AddressBook.Models
↓
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
│
├── AddressBook.sln
│
├── AddressBook.API
│ ├── Controllers
│ └── Program.cs
│
├── AddressBook.Models
│ ├── Models
│ └── DTOs
│
├── AddressBook.Repository
│ ├── Interfaces
│ └── Repositories
│
└── AddressBook.Service
├── Interfaces
└── Services
Progress
✅ Day 11 Completed

Repository Structure

```text
Refresher-Training
│
├── README.md
│
├── day1-RDBMS
├── day2-ER-Indexing-Normalization
├── Day3-Store-Joins-Trigger
├── day4-HealthClinicApp
├── day5-WebAPI-Project
├── day6-GreetingApp
├── day7-contactapp
├── Day8-ContactManagement
├── Day9-EntityContact
└── Day10-AddressBookAPI
```

---

# Technology Progress

```text
SQL
 ↓
DBMS / RDBMS
 ↓
ER Diagram
 ↓
Normalization
 ↓
Indexing
 ↓
Stored Procedures
 ↓
Triggers
 ↓
ADO.NET
 ↓
ASP.NET Core Web API
 ↓
ASP.NET Core MVC
 ↓
Minimal API
 ↓
Repository Pattern
 ↓
Service Layer
 ↓
Entity Framework Core
 ↓
EF Core Migrations
 ↓
Layered Web API Architecture
```

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
```

---

## Author

**Ujjawal Verma**
