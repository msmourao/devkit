# DevKit package list (nuget.org)

Current train: **`0.1.0-preview.4`**

## DevKit shell

| Package | Role |
|---------|------|
| `PolyStack.DevKit.Abstractions` | Topology schema / validation / catalog types |
| `PolyStack.DevKit.Host` | Local host wiring (InMemory broker) |
| `PolyStack.DevKit.Aspire` | AppHost facade (`AsPolyStackDistributedApplicationBuilder`, scheme export, sidecar attach) |
| `PolyStack.DevKit.Sidecar` | Read-only catalog UI on `:18889` (runnable `tools/` payload) |
| `PolyStack.Architecture.Testing` | Architecture convention tests |

## Application / presentation

| Package |
|---------|
| `PolyStack.Application.Core` |
| `PolyStack.Application.Cqrs.Abstractions` |
| `PolyStack.Application.Mapping.Abstractions` |
| `PolyStack.Application.Persistence.Abstractions` |
| `PolyStack.Presentation.Core` |
| `PolyStack.Presentation.HostedService` |
| `PolyStack.Presentation.Auth.Abstractions` |
| `PolyStack.Presentation.Auth.None` |
| `PolyStack.Presentation.Auth.Provider.Abstractions` |
| `PolyStack.Presentation.Auth.Provider.None` |

## Domain / shared

| Package |
|---------|
| `PolyStack.Common` |
| `PolyStack.Domain` |
| `PolyStack.Mediator` |
| `PolyStack.Grpc.Contracts` |
| `PolyStack.ServiceDefaults` |
| `PolyStack.Hints.Abstractions` |
| `PolyStack.Infrastructure.Core` |

## Messaging / storage / persistence (local-first)

| Package |
|---------|
| `PolyStack.Infrastructure.MessageBroker.Abstractions` |
| `PolyStack.Infrastructure.MessageBroker.Core` |
| `PolyStack.Infrastructure.MessageBroker.InMemory` |
| `PolyStack.Infrastructure.MessageBroker.Resources.Abstractions` |
| `PolyStack.Infrastructure.ObjectStorage.Abstractions` |
| `PolyStack.Infrastructure.ObjectStorage.Disabled` |
| `PolyStack.Infrastructure.Persistence.Abstractions` |
| `PolyStack.Infrastructure.Persistence.Core` |
| `PolyStack.Infrastructure.Persistence.DatabaseProvider.Abstractions` |
| `PolyStack.Infrastructure.Persistence.Sqlite` |
| `PolyStack.Infrastructure.WebSocket.Abstractions` |
| `PolyStack.Infrastructure.WebSocket.Core` |
| `PolyStack.Infrastructure.WebSocket.Disabled` |
| `PolyStack.Infrastructure.WebSocket.SignalR` |

## Not in this feed (platform — private)

`Host.BuildTimeSelection`, `MessageBroker.DynamicSelection`, `*.Aws`, `*.Azure`, `Settings.*`, `Aspire.MulticloudDevelopmentKit.*`, `ProjectGenerator`, `Deploy`, `Grpc.Codegen`, `Inventory.*`, cloud persistence adapters used by the full stack, etc.
