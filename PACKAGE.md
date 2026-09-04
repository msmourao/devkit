# PolyStack DevKit

Local-first packages for structuring PolyStack-shaped applications and exporting architecture metadata (`*.polystack-scheme.json`).

## Install

```powershell
dotnet add package PolyStack.DevKit.Host --version 0.1.0-preview.4
dotnet add package PolyStack.DevKit.Aspire --version 0.1.0-preview.4
dotnet add package PolyStack.DevKit.Abstractions --version 0.1.0-preview.4
dotnet add package PolyStack.DevKit.Sidecar --version 0.1.0-preview.4
```

## Docs

- Full bilingual guide: [doc/](https://github.com/getpolystack/polystack-devkit/tree/main/doc) (GitHub Pages) · [DevelopmentGuide.md](https://github.com/getpolystack/polystack-devkit/blob/main/DevelopmentGuide.md)
- Blank Aspire sample: [samples/blank](https://github.com/getpolystack/polystack-devkit/tree/main/samples/blank)
- Repository: [getpolystack/polystack-devkit](https://github.com/getpolystack/polystack-devkit)

## Sidecar

After a DevKit AppHost `Build()`, open **http://localhost:18889/** to download `*.polystack-scheme.json` (metadata only — no secrets, binaries, or live URLs).
