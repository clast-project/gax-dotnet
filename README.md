# Clast fork — Newtonsoft-free, AOT-ready republish

> This is the **`clast-project`** fork of [`googleapis/gax-dotnet`](https://github.com/googleapis/gax-dotnet). It republishes the three libraries below under a **`Clast.`** package-id prefix, with **`Newtonsoft.Json` replaced by source-generated `System.Text.Json`** (the GCE/GKE/Cloud Run platform-detail parsing moved to `System.Text.Json.Nodes`), made **trimming/AOT-compatible**, and a **`net10.0`** target added. Namespaces and public type names are **unchanged**.
>
> **Why:** these are part of the Newtonsoft-free, AOT-ready Clast dependency closure; `Google.Api.Gax.Rest` is repointed to the ported `Clast.Google.Apis.Auth`, and `Google.Api.Gax.Grpc` enables the gRPC-based Cloud client libraries (e.g. `Google.Cloud.BigQuery.Storage.V1`) under Native AOT.
>
> **Packages republished from this repository:**
>
> | Clast package | Upstream package |
> |---|---|
> | `Clast.Google.Api.Gax` | `Google.Api.Gax` |
> | `Clast.Google.Api.Gax.Rest` | `Google.Api.Gax.Rest` |
> | `Clast.Google.Api.Gax.Grpc` | `Google.Api.Gax.Grpc` |
>
> **Gax.Grpc AOT notes:** on `net10.0` the gRPC transport uses `GrpcNetClientAdapter` (`Grpc.Net.Client`), the default on modern .NET; the legacy native `GrpcCoreAdapter` (`Grpc.Core`, deprecated) relies on runtime code generation and is therefore inert under Native AOT (see `BEHAVIORAL-CHANGES.md` BC-020/BC-021). The protobuf/gRPC dependencies (`Google.Protobuf`, `Grpc.*`, `Google.Api.CommonProtos`) are kept as their published packages and treated as AOT-compatible unchanged.
>
> The other Gax `.Testing` packages are out of scope. The renaming/re-signing is gated behind an opt-in `-p:Clast=true` MSBuild flag (default builds keep the original identity). The full design notes and behavior-change catalogue live in the [`clast-project/google-api-dotnet-client`](https://github.com/clast-project/google-api-dotnet-client) repo (`PLAN.md`, `BEHAVIORAL-CHANGES.md`).

---

[![GitHub Actions status](https://img.shields.io/github/actions/workflow/status/googleapis/gax-dotnet/build.yml?branch=main)](https://github.com/googleapis/gax-dotnet/actions/workflows/build.yml)

# Google API Extensions for .NET

This repository contains code for support libraries for the
[Google Cloud Libraries for
.NET](https://github.com/GoogleCloudPlatform/google-cloud-dotnet).
See the [API
reference](https://googlecloudplatform.github.io/google-cloud-dotnet/docs/api/Google.Api.Gax.html)
and [API
layers](https://googlecloudplatform.github.io/google-cloud-dotnet/docs/guides/api-layers.html)
documentation for more details of how these support libraries are
used.

Application code will rarely need to use most of the classes within this
library directly, but code generated automatically from the [API definition
files](https://github.com/googleapis/googleapis/)
can use services such as page streaming to provide
a more convenient and idiomatic API surface to callers.

## Contributing

Contributions to this library are always welcome and highly encouraged.
See the	[CONTRIBUTING](https://github.com/googleapis/gax-dotnet/blob/main/.github/CONTRIBUTING.md)
documentation for more information on how to get started.

## Versioning

This library follows [semantic versioning](http://semver.org).

## License

BSD-3-Clause - See [LICENSE](./LICENSE) for more information.
