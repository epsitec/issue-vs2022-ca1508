# issue-vs2022-ca1508

Demonstrates an issue with `CA1508` warning.

Compile and see `GenerateWarning.cs` on line 16.

> warning CA1508: 'customer.LastName.Length == 0' is always 'true'. Remove or refactor the condition(s) to avoid dead code.

See [issue in Developer Community](https://developercommunity.visualstudio.com/t/CA1508-reported-incorrectly/1618815).

## Tested with SDK Version 6.0.101

```cmd
dotnet build
```

produces this output:

```log
Welcome to .NET 6.0!
---------------------
SDK Version: 6.0.101

Telemetry
---------
The .NET tools collect usage data in order to help us improve your experience. It is collected by Microsoft and shared with the community. You can opt-out of telemetry by setting the DOTNET_CLI_TELEMETRY_OPTOUT environment variable to '1' or 'true' using your favorite shell.

Read more about .NET CLI Tools telemetry: https://aka.ms/dotnet-cli-telemetry

----------------
Installed an ASP.NET Core HTTPS development certificate.
To trust the certificate run 'dotnet dev-certs https --trust' (Windows and macOS only).
Learn about HTTPS: https://aka.ms/dotnet-https
----------------
Write your first app: https://aka.ms/dotnet-hello-world
Find out what's new: https://aka.ms/dotnet-whats-new
Explore documentation: https://aka.ms/dotnet-docs
Report issues and find source on GitHub: https://github.com/dotnet/core
Use 'dotnet --help' to see available commands or visit: https://aka.ms/dotnet-cli
--------------------------------------------------------------------------------------
Microsoft (R) Build Engine version 17.0.0+c9eb9dd64 for .NET
Copyright (C) Microsoft Corporation. All rights reserved.

  Determining projects to restore...
  Restored S:\git\tmp\issue-vs2022-ca1508\ClassLibrary\ClassLibrary.csproj (in 218 ms).
  Restored S:\git\tmp\issue-vs2022-ca1508\Program\Program.csproj (in 220 ms).
  ClassLibrary -> S:\git\tmp\issue-vs2022-ca1508\ClassLibrary\bin\Debug\net6.0\ClassLibrary.dll
CSC : warning CA1014: Mark assemblies with CLSCompliant [S:\git\tmp\issue-vs2022-ca1508\Program\Program.csproj]
S:\git\tmp\issue-vs2022-ca1508\Program\GenerateWarning.cs(16,14): warning CA1508: 'customer.LastName.Length == 0' is always 'true'. Remove or refactor the condition(s) to avoid dead code. [S:\git\tmp\issue-vs2022-ca1508\Program\Program.csproj]
  Program -> S:\git\tmp\issue-vs2022-ca1508\Program\bin\Debug\net6.0\Program.dll

Build succeeded.

CSC : warning CA1014: Mark assemblies with CLSCompliant [S:\git\tmp\issue-vs2022-ca1508\Program\Program.csproj]
S:\git\tmp\issue-vs2022-ca1508\Program\GenerateWarning.cs(16,14): warning CA1508: 'customer.LastName.Length == 0' is always 'true'. Remove or refactor the condition(s) to avoid dead code. [S:\git\tmp\issue-vs2022-ca1508\Program\Program.csproj]
    2 Warning(s)
    0 Error(s)

Time Elapsed 00:00:06.08
```
