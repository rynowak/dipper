# dipper

Sending your microservices productivity into the stars!

What dipper can do:

- Run multiple projects locally.
- Easily manage dependencies running containers.
- Automatically build Docker images by following .NET's conventions.
- Generate manifests for Kubenetes (static deployments/services, Helm Charts, OAM).
- Express relationships and dependencies between services.
- Make secret management and service discovery easy.
- Let you configure all of this with C# code (`.csx`) or yaml!

## Current Status

![CI](https://github.com/rynowak/dipper/workflows/ci/badge.svg)

Dipper will be a combination of [Opulence](https://github.com/rynowak/opulence) and [Micronetes](https://github.com/davidfowl/micronetes) into a single tool.

There's not much to see here right now, but keep watching this space for updates.

## Installing the dipper CLI

First, install the [.NET Core 3.1 SDK](https://dotnet.microsoft.com/download/dotnet-core/3.1) (or newer if you are viewing this in the far future).

Then... run the following command with the version of the latest build. Unfortunately `dotnet tool install` requires you to specify the exact package version.

```sh
dotnet tool install -g --add-source https://f.feedz.io/dipper/dipper/nuget/index.json --version "{version}" dip

dip --version
> 0.1.27-alpha+feada8b0f8
```

You can find the latest version [here](https://feedz.io/org/dipper/repository/dipper/packages/dip).

[![feedz.io](https://img.shields.io/badge/endpoint.svg?url=https%3A%2F%2Ff.feedz.io%2Fdipper%2Fdipper%2Fshield%2Fdip%2Flatest&label=dip)](https://f.feedz.io/dipper/dipper/packages/dip/latest/download)

## Getting started

TBD