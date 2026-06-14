# Clast republish

This is a **Clast** package — an independent republish (from the [`clast-project`](https://github.com/clast-project) fork) of a Google .NET library. **It is not an official Google package and is not affiliated with or endorsed by Google.**

**How it differs from the upstream package:**

- `Newtonsoft.Json` is replaced with **source-generated `System.Text.Json`** (the GCE/GKE/Cloud Run platform-detail parsing uses `System.Text.Json.Nodes`).
- The library is **trimming / Native-AOT compatible**, with a **`net10.0`** target added (alongside `netstandard2.0` and `net8.0`).
- **Namespaces and public type names are unchanged.** Only the package id, assembly name, and strong-name key differ, so you recompile against the `Clast.*` packages rather than dropping them in as binary replacements.

**Packages republished from this repository:** `Clast.Google.Api.Gax`, `Clast.Google.Api.Gax.Rest`, `Clast.Google.Api.Gax.Grpc`.

For `Clast.Google.Api.Gax.Grpc`, the gRPC transport on `net10.0` uses `GrpcNetClientAdapter` (`Grpc.Net.Client`); the legacy native `GrpcCoreAdapter` (`Grpc.Core`) is not supported under Native AOT. The protobuf/gRPC dependencies (`Google.Protobuf`, `Grpc.*`, `Google.Api.CommonProtos`) are referenced as their published packages.

Full design notes and the behavior-change catalogue live in the [`clast-project/google-api-dotnet-client`](https://github.com/clast-project/google-api-dotnet-client) repository (`PLAN.md`, `BEHAVIORAL-CHANGES.md`).
