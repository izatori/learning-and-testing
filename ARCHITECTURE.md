# DDD Architecture - Project Structure & Dependency Rules

## Multi-Project Architecture

The solution is now organized into separate projects, each representing a layer in Domain-Driven Design. **Project references enforce architectural boundaries** — if a layer tries to reference something it shouldn't, the compiler will throw an error.

```
LearningAndTesting (Entry Point)
    └── References: LearningAndTesting.Presentation
        
LearningAndTesting.Presentation
    └── References: LearningAndTesting.Application
        ✗ CANNOT reference: Domain, Infrastructure
        
LearningAndTesting.Application
    └── References: LearningAndTesting.Domain
        ✗ CANNOT reference: Infrastructure, Presentation
        
LearningAndTesting.Infrastructure
    └── References: LearningAndTesting.Domain, LearningAndTesting.Application
        ✗ CANNOT reference: Presentation
        
LearningAndTesting.Domain
    └── References: NOTHING (no external dependencies)
        ✗ CANNOT reference: Application, Infrastructure, Presentation
```

## Allowed Dependencies (Compile-Time Enforcement)

| Layer | Can Reference | Cannot Reference |
|-------|---|---|
| **Presentation** | Application | Domain, Infrastructure |
| **Application** | Domain | Infrastructure, Presentation |
| **Infrastructure** | Domain, Application | Presentation |
| **Domain** | Nothing | Everything |

## Why This Matters

### ✅ Domain Layer (Pure Business Logic)
- **No external dependencies** — completely isolated
- Contains core business concepts: Entities, Value Objects, Repository Interfaces, Domain Services
- Can be tested without any infrastructure
- **Example**: A Domain class can NEVER reference a DTO from Application

### ✅ Application Layer (Use Cases)
- Orchestrates Domain objects
- Can only reference Domain
- Contains DTOs, Services, Use Cases
- **Example**: CarDTO can ONLY be used in Application and Presentation, NEVER in Domain

### ✅ Infrastructure Layer (Technical Concerns)
- Implements repository interfaces from Domain
- Handles databases, file systems, external APIs
- Can reference both Domain and Application
- **Example**: Database implementations, email services

### ✅ Presentation Layer (User Interface)
- Handles HTTP requests, console output, UI
- Only references Application
- **Example**: Controllers, API models, console menu

## Compile-Time Boundary Enforcement

If you try to do this in Domain code:
```csharp
using LearningAndTesting.Application.DTOs.Car; // ERROR!

public class Car
{
    public CarDTO GetData() // This won't compile!
    {
        return new CarDTO();
    }
}
```

**The compiler will fail** because `LearningAndTesting.Domain` project doesn't reference `LearningAndTesting.Application` project.

## Example: Correct Data Flow

```
User Request
    ↓
Presentation Layer (Controller)
    ↓ uses Application Service
Application Layer (CreateCarUseCase)
    ↓ uses Domain logic
Domain Layer (Car Entity, CarService)
    ↓ needs persistence
Repository Interface (in Domain)
    ↓ implemented by
Infrastructure Layer (CarRepository)
    ↓ reads/writes to
Database
```

## Best Practices

1. **Domain layer is sacred** — protect it from all external concerns
2. **Application layer is thin** — it orchestrates, doesn't implement
3. **Infrastructure is replaceable** — change database, email provider without touching Domain
4. **Dependencies point inward** — Presentation → Application → Domain (never reverse)

## File Organization

```
LearningAndTesting.Domain/
├── Entities/
│   ├── BaseEntity.cs
│   └── Car.cs (domain model)
├── ValueObjects/
├── Repositories/ (INTERFACES only)
│   └── ICarRepository.cs
└── DomainServices/
    ├── VariableTypes.cs
    └── SyntaxBasics.cs

LearningAndTesting.Application/
├── DTOs/
│   └── Car/
│       ├── CreateCarDTO.cs
│       ├── CarDTO.cs
│       ├── UpdateCarDTO.cs
│       └── CarListResponseDTO.cs
├── Services/
└── UseCases/
    └── CreateCarUseCase.cs

LearningAndTesting.Infrastructure/
├── Persistence/
│   ├── DatabaseContext.cs
│   └── CarRepository.cs (IMPLEMENTATION)
└── ExternalServices/

LearningAndTesting.Presentation/
├── Controllers/
└── Models/

LearningAndTesting/ (Entry Point)
└── Program.cs
```

This architecture ensures DDD compliance at compile-time! 🎯
