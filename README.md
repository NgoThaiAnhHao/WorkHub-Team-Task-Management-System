# FILE STRUCTURE
MyProject/
│
├── MyProject.sln
│
├── src/
│   ├── MyProject.API/
│   │   ├── Controllers/
│   │   ├── Middlewares/
│   │   ├── Extensions/
│   │   ├── Filters/
│   │   ├── Program.cs
│   │   ├── appsettings.json
│   │   ├── appsettings.Development.json
│   │   └── MyProject.API.csproj
│   │
│   ├── MyProject.Application/
│   │   ├── DTOs/
│   │   ├── Interfaces/
│   │   ├── Services/
│   │   ├── Features/
│   │   │   ├── Activities/
│   │   │   │   ├── Commands/
│   │   │   │   └── Queries/
│   │   │   └── Users/
│   │   └── MyProject.Application.csproj
│   │
│   ├── MyProject.Domain/
│   │   ├── Entities/
│   │   ├── Enums/
│   │   ├── ValueObjects/
│   │   └── MyProject.Domain.csproj
│   │
│   └── MyProject.Infrastructure/
│       ├── Persistence/
│       │   ├── AppDbContext.cs
│       │   ├── Configurations/
│       │   ├── Migrations/
│       │   └── Seed/
│       ├── Repositories/
│       ├── Services/
│       └── MyProject.Infrastructure.csproj
│
├── tests/
│   ├── MyProject.UnitTests/
│   └── MyProject.IntegrationTests/
│
├── .gitignore
├── README.md
└── Directory.Build.props