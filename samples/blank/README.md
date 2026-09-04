# Blank Aspire sample (local DevKit feed)

Minimal PolyStack DevKit AppHost with **no ProjectReferences** to the private monorepo.

## Packages (`0.1.0-preview.4`, obfuscated)

Local feed: [`packages/`](packages/) (preferred via `NuGet.config`).

- `PolyStack.DevKit.Aspire`
- `PolyStack.DevKit.Sidecar`
- transitive `PolyStack.*` DevKit runtime packages
- `Aspire.Hosting.AppHost` `13.5.3` (from nuget.org)

## Run

```powershell
dotnet restore
dotnet run --project PolyStackBlankSolutionSample.AppHost
```

Open **http://localhost:18889/** after the host starts.

The AppHost already calls `AsPolyStackDistributedApplicationBuilder()` and `Build().Run()`. Add modules when you have Presentation + ApplicationBuilder types — see comments in `PolyStackBlankSolutionSample.AppHost/AppHost.cs` and the [Development Guide](../../doc/) ([markdown summary](../../DevelopmentGuide.md)).

## Notes

- `Directory.Build.props` / `Directory.Packages.props` disable central package management so this sample stays portable.
- `NuGet.config` maps `PolyStack.*` to `./packages` and everything else to nuget.org.
- Generated `.polystack/` files appear after Build and are gitignored.
