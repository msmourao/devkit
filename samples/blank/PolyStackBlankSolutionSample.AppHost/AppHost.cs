using PolyStack.Aspire.MulticloudDevelopmentKit;

var builder = DistributedApplication.CreateBuilder(args);

// -----------------------------------------------------------------------------
// PolyStack DevKit (nuget.org packages: PolyStack.DevKit.Aspire / Sidecar)
// Guide: https://github.com/getpolystack/polystack-devkit
//
// 1) Wrap the Aspire builder with the DevKit facade (same method names as the
//    private Multicloud kit — swap packages later without rewriting AppHost):
//
//      var poly = builder.AsPolyStackDistributedApplicationBuilder();
//
// 2) Register modules once you have Presentation + ApplicationBuilder types:
//
//      poly.AddPolyStackModule<MyPresentation, MyApplicationBuilder>("my-api");
//
// 3) Optional: declare logical sync edges / externals (Docker, Vite, Python):
//
//      poly.AddSynchronousModuleCall("Frontend", "MyModule");
//      // resource.AsExternalPolyStackModule(poly, "Scanner", StackModuleSource.Python);
//
// 4) Build through the facade so DevKit writes *.polystack-scheme.json under
//    .polystack/ and starts the sidecar on http://localhost:18889/
//
//      poly.Build().Run();
//      return;
//
// Until you add modules, this blank AppHost stays a plain Aspire host.
// -----------------------------------------------------------------------------

var poly = builder.AsPolyStackDistributedApplicationBuilder();
poly.Build().Run();
