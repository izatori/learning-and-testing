# Data Transfer Objects (DTOs)

DTOs are used to transfer data between layers without exposing domain entities.
They are simple objects that carry data with minimal logic, providing a contract between layers.

## Purpose

- **Decouple layers**: Presentation and Application don't directly share Domain entities
- **Data shaping**: Expose only necessary data, hide internal domain logic
- **Validation**: Apply input/output validation rules specific to API contracts
- **Backward compatibility**: Change internal domain models without breaking APIs

## Naming Conventions

- `CreateXDTO` - For creating new entities (POST requests)
- `UpdateXDTO` - For updating entities (PUT/PATCH requests)
- `XDTO` - For reading/returning entity data (GET responses)
- `XListResponseDTO` - For paginated list responses

## Example Structure

```
Application/
└── DTOs/
    ├── User/
    │   ├── CreateUserDTO.cs
    │   ├── UpdateUserDTO.cs
    │   ├── UserDTO.cs
    │   └── UserListResponseDTO.cs
    ├── Order/
    │   ├── CreateOrderDTO.cs
    │   └── OrderDTO.cs
    └── README.md
```

## Best Practices

1. **Keep DTOs simple** - Use auto-properties, minimal logic
2. **Use validation attributes** - Decorate with DataAnnotations for input validation
3. **Make properties nullable** for optional fields in Update DTOs
4. **Never inherit from domain entities** - DTOs are separate from domain models
5. **Include XML documentation** - Document all public properties for API consumers
