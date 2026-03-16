# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

**MarcusMedina.Fluent.TypedMath** - A C# NuGet package providing type-safe mathematical operations with physical units and domain-specific models for physics, engineering, and finance.

- **Language:** C# 14.0
- **Framework:** .NET 10.0+
- **Pattern:** Fluent Builder API with typed mathematical operations
- **License:** MIT

## Quick Commands

### Development
```bash
# Restore and build
cd csharp
dotnet restore
dotnet build --configuration Release

# Run tests
dotnet test --configuration Release

# Pack NuGet package
dotnet pack src/TypedMath/TypedMath.csproj --configuration Release

# Run single test
dotnet test --filter ClassName.MethodName
```

### Release & Publishing
```bash
# Create version tag (triggers GitHub Actions)
git tag -a v2.0.0 -m "Release v2.0.0"
git push origin v2.0.0

# The multi-stage GitHub Actions pipeline will:
# 1. Build and test
# 2. Run CodeQL security analysis
# 3. Sign packages with certificate
# 4. Publish to NuGet.org
```

## Architecture

### Core Concepts

**Type-Safe Mathematical Operations**
- Compile-time unit safety prevents category mismatches
- Physics, engineering, and finance domain models
- No runtime string-based unit specifications
- Zero-cost abstractions via compiler optimization

### Key Components

**Domain Packages:**
- Physics module — motion, forces, energy calculations
- Engineering module — thermal, electrical, mechanical systems
- Finance module — financial calculations and models

**Builders** (`Builders/`)
- Fluent interfaces for mathematical operations
- Chainable method syntax for intuitive usage
- Type-safe unit conversions

**Extensions** (`Extensions/`)
- Extension methods for mathematical functions
- Domain-specific calculation helpers
- Utility functions for physics/engineering/finance

### File Structure
```
csharp/
├── src/TypedMath/
│   ├── Domain/              # Physics, Engineering, Finance models
│   ├── Builders/            # Fluent builder implementation
│   ├── Extensions/          # Extension methods
│   ├── Interfaces/          # Core contracts
│   └── GlobalUsings.cs      # Global namespace imports
└── tests/TypedMath.Tests/
    └── *Tests.cs            # xUnit test suite
```

## Testing Strategy

- **Framework:** xUnit with FluentAssertions
- **Coverage:** 85%+ target
- **Approach:** Comprehensive unit tests for all mathematical operations and domain models
- Tests verify:
  - Type-safe operation correctness
  - Unit conversion accuracy
  - Domain-specific calculations
  - Edge cases and boundary conditions

## GitHub Actions Workflow

**Release Pipeline** (`.github/workflows/release.yml`)

Triggers on: `git push` with `v*` tags or to `main`/`release` branches

4-stage pipeline:
1. **Build & Test** - Restore, build, test, pack (produces unsigned packages)
2. **Quality Gate** - CodeQL analysis, vulnerability scanning
3. **Package Signing** - Sign packages, verify signatures, generate SHA256 checksums
4. **Publish to NuGet** - Only runs on version tags (refs/tags/v*)

**Required Secrets:**
- `NUGET_API_KEY` - NuGet.org API key
- `NUGET_SIGNING_CERT` - Base64-encoded signing certificate (.pfx)
- `NUGET_SIGNING_CERT_PASSWORD` - Certificate password

## Type-Safe Mathematical Operations

All mathematical operations are strongly typed to prevent unit category confusion:

**Physics Domain:**
- Distance, velocity, acceleration, force, energy
- Compile-time guarantees on unit compatibility
- Example: Adding meters to kilograms fails at compile time

**Engineering Domain:**
- Temperature, power, resistance, frequency
- Domain-specific calculations
- Example: Thermal load calculations with proper unit handling

**Finance Domain:**
- Currency, interest rates, investment calculations
- Type-safe financial operations
- Example: Currency conversion with explicit rate handling

## NuGet Package Configuration

Key settings in `.csproj`:
- **Version:** Bumped via git tags in CI
- **Package ID:** `MarcusMedina.Fluent.TypedMath`
- **Description:** Type-safe mathematical operations for physics, engineering, and finance
- **License:** MIT (requires LICENSE file in root)
- **Repository:** GitHub repository URL
- **Project URL:** Links to documentation

## Documentation

- **README.md** - Quick start, features, installation
- **CHANGELOG.md** - Version history with breaking changes
- **documents/** - Comprehensive user guide and examples (if present)
- **LICENSE** - MIT License file (required for NuGet)

## Common Issues & Solutions

**Build Fails on Test Project:**
- Verify path in test .csproj: `../../src/TypedMath/TypedMath.csproj`

**Type Conversion Issues:**
- Ensure units are compatible (km to m is OK, meters to seconds is not)
- Check that domain-specific types are properly imported

**GitHub Actions Workflow Fails:**
- Check that `csharp/` folder structure matches workflow paths
- Verify secrets are configured in repository settings
- Ensure .NET 10.0.x is available in ubuntu-latest

## Semantic Versioning

Version format: `MAJOR.MINOR.PATCH`

- **MAJOR** - Breaking changes to API or type system
- **MINOR** - New features, backwards compatible
- **PATCH** - Bug fixes, no API changes

Breaking changes are documented in CHANGELOG with migration guides.
