[![](https://img.shields.io/nuget/v/soenneker.libraries.nuget.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.libraries.nuget/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.libraries.nuget/build-and-test.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.libraries.nuget/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/nuget/dt/soenneker.libraries.nuget.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.libraries.nuget/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.libraries.nuget/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.libraries.nuget/actions/workflows/codeql.yml)

# Soenneker.Libraries.NuGet

Adds the NuGet cli executable (nuget.exe), updated daily (if available).

## Install

```bash
dotnet add package Soenneker.Libraries.NuGet
```

## What it provides

- Adds the NuGet cli executable (nuget.exe), updated daily (if available).
- The file is copied to the output directory, and located at the relative path: `Resources\`.

## How to use it

After installation, resolve the packaged file from the output-relative path above. The package deploys the asset but does not invoke it for you.
