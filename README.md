[![](https://img.shields.io/nuget/v/soenneker.libraries.nuget.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.libraries.nuget/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.libraries.nuget/build-and-test.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.libraries.nuget/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/nuget/dt/soenneker.libraries.nuget.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.libraries.nuget/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.libraries.nuget/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.libraries.nuget/actions/workflows/codeql.yml)

# Soenneker.Libraries.NuGet

The NuGet command-line executable packaged as a .NET content asset.

## Install

```bash
dotnet add package Soenneker.Libraries.NuGet
```

The package copies `nuget.exe` beneath the application output directory:

```csharp
string nuget = Path.Combine(AppContext.BaseDirectory, "Resources", "nuget.exe");
```

This package supplies the executable but does not start or configure NuGet. Prefer the `dotnet nuget` commands when they cover the required operation; use this package for NuGet CLI commands that need `nuget.exe` specifically.

Pass each value through `ProcessStartInfo.ArgumentList`. Do not place feed API keys in logged command strings, and check the process exit code before treating an operation as successful.
