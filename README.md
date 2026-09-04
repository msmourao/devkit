# polystack-devkit

Public **PolyStack DevKit** documentation, package metadata, and a nuget.org-only blank Aspire sample.

Use this repository to learn the DevKit surface, export `*.polystack-scheme.json`, and start a new AppHost without the private Multicloud platform.

| Artifact | Purpose |
|----------|---------|
| [`doc/`](./doc/) | **GitHub Pages** — React DevKit development guide (EN / PT-BR) |
| [DevelopmentGuide.md](./DevelopmentGuide.md) | Short markdown summary + pointer to `doc/` |
| [PACKAGE.md](./PACKAGE.md) | Short README embedded in `PolyStack.DevKit.*` NuGet packages |
| [samples/blank](./samples/blank) | Minimal Aspire AppHost with local obfuscated `packages/` feed |
| `packages/` | Optional staging folder for Trusted Publishing / release assets (gitignored binaries) |

## NuGet

Current train: **`0.1.0-preview.4`** (obfuscated binaries)

```powershell
dotnet add package PolyStack.DevKit.Aspire --version 0.1.0-preview.4
dotnet add package PolyStack.DevKit.Sidecar --version 0.1.0-preview.4
dotnet add package PolyStack.DevKit.Host --version 0.1.0-preview.4
dotnet add package PolyStack.DevKit.Abstractions --version 0.1.0-preview.4
```

## Quick start (blank sample)

The blank sample restores `PolyStack.*` from [`samples/blank/packages`](./samples/blank/packages) (local obfuscated feed).

```powershell
cd samples/blank
dotnet restore
dotnet run --project PolyStackBlankSolutionSample.AppHost
```

Then open the DevKit sidecar: [http://localhost:18889/](http://localhost:18889/)

Register modules on the AppHost facade when you are ready; until then the catalog may show an empty state (expected for a blank host).

## Sidecar

- Local UI after AppHost `Build()`: **http://localhost:18889/**
- Scheme file: architecture **metadata only** (no secrets, binaries, or live URLs)
- Language: browser `Accept-Language` / `navigator.language`, with `?lang=pt` / `?lang=en`

## Maintainers

Pack and push from the private PolyStack monorepo (`scripts/publish-devkit.ps1`), or attach `.nupkg` files to a GitHub Release and use [`.github/workflows/publish.yml`](./.github/workflows/publish.yml) (Trusted Publishing). See [PUBLISH.md](./PUBLISH.md).
