# PolyStack DevKit — Development Guide

> **HTML guide (GitHub Pages):** open [`/doc/`](./doc/) in this repository  
> (built from the React app in `polystack-doc`).

Public, local-first guide for structuring PolyStack-shaped applications and exporting an architecture scheme.

**Repository:** [github.com/getpolystack/polystack-devkit](https://github.com/getpolystack/polystack-devkit)  
**Packages:** `0.1.0-preview.4` (obfuscated) on [nuget.org](https://www.nuget.org/packages/PolyStack.DevKit.Aspire)  
**Blank sample:** local feed at [`samples/blank/packages`](./samples/blank/packages)

The bilingual interactive guide lives under **[`doc/`](./doc/)** (`?lang=en` / `?lang=pt`). Markdown sources are maintained in the `polystack-doc` React app (`content/guide.en.md`, `content/guide.pt.md`).

---

## English (summary)

### Quick start (blank sample)

```powershell
cd samples/blank
dotnet restore
dotnet run --project PolyStackBlankSolutionSample.AppHost
# sidecar: http://localhost:18889/
```

```powershell
dotnet add package PolyStack.DevKit.Aspire --version 0.1.0-preview.4
dotnet add package PolyStack.DevKit.Sidecar --version 0.1.0-preview.4
```

### Compose modules

```csharp
var poly = builder.AsPolyStackDistributedApplicationBuilder();
poly.AddPolyStackModule<MyPresentation, MyApplicationBuilder>("mymodule-api");
poly.Build().Run();
```

### Export scheme

1. Build / F5 the DevKit AppHost.
2. Open **http://localhost:18889/**.
3. Generate and download `*.polystack-scheme.json` (metadata only — no secrets/binaries/live URLs).

---

## Português (resumo)

### Início rápido

```powershell
cd samples/blank
dotnet restore
dotnet run --project PolyStackBlankSolutionSample.AppHost
# sidecar: http://localhost:18889/
```

### Compor módulos

```csharp
var poly = builder.AsPolyStackDistributedApplicationBuilder();
poly.AddPolyStackModule<MyPresentation, MyApplicationBuilder>("mymodule-api");
poly.Build().Run();
```

### Exportar scheme

1. Build / F5 do AppHost DevKit.
2. Abra **http://localhost:18889/**.
3. Gere e baixe `*.polystack-scheme.json` (só metadados).

---

For the full bilingual guide with tables and checklists, use the Pages site in [`doc/`](./doc/).
