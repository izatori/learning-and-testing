# Domain-Driven Design (DDD) Structure

This project follows Domain-Driven Design principles with the following layered architecture:

## Architecture Layers

### 1. Domain Layer (Core Business Logic)
- **Entities**: Objects with identity that evolve over time
  - Inherit from `BaseEntity`
  - Contain business logic
  
- **Value Objects**: Immutable objects that represent descriptive aspects
  - No identity, defined by their attributes
  - Example: Money, Email, Address
  
- **Repositories (Interfaces)**: Contracts for data access
  - Define methods for persisting and retrieving entities
  
- **Domain Services**: Stateless services for business logic
  - Operations that don't fit naturally in entities/value objects

### 2. Application Layer (Use Cases & Orchestration)
- **Application Services**: Coordinate domain objects to fulfill use cases
  - Stateless services orchestrating domain logic
  
- **DTOs**: Data Transfer Objects
  - Transfer data between layers without exposing domain entities
  
- **Use Cases**: Specific business scenarios
  - Each represents a distinct business workflow

### 3. Infrastructure Layer (Technical Implementation)
- **Persistence**: Repository implementations
  - `DatabaseContext`: ORM context
  - `Repository<T>`: Generic repository implementation
  
- **External Services**: Third-party integrations
  - Email, Payment, Logging, etc.

### 4. Presentation Layer (User Interface)
- **Controllers**: Handle HTTP requests/responses
  - Delegate to application services
  
- **API Models**: API request/response contracts
  - Different from DTOs, represents the API interface

## Key Principles

1. **Dependency Inversion**: High-level modules don't depend on low-level modules. Both depend on abstractions.
2. **Separation of Concerns**: Each layer has a specific responsibility.
3. **Domain-Centric**: Business logic is in the domain layer, not scattered across layers.
4. **Testability**: Each layer can be tested independently.

## Data Flow

```
Request → Presentation (Controller)
       ↓
Application (Service/UseCase)
       ↓
Domain (Entity/DomainService)
       ↓
Infrastructure (Repository)
       ↓
Database
```

## Example Project Structure

```
LearningAndTesting/
├── Domain/
│   ├── Entities/
│   │   ├── BaseEntity.cs
│   │   └── User.cs
│   ├── ValueObjects/
│   │   └── Email.cs
│   ├── Repositories/
│   │   └── IUserRepository.cs
│   └── DomainServices/
│       └── UserValidationService.cs
├── Application/
│   ├── Services/
│   │   └── UserApplicationService.cs
│   ├── DTOs/
│   │   └── CreateUserDTO.cs
│   └── UseCases/
│       └── CreateUserUseCase.cs
├── Infrastructure/
│   ├── Persistence/
│   │   ├── DatabaseContext.cs
│   │   └── UserRepository.cs
│   └── ExternalServices/
│       └── EmailService.cs
└── Presentation/
    ├── Controllers/
    │   └── UserController.cs
    └── Models/
        └── CreateUserRequest.cs
```
