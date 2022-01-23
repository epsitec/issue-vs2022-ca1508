# issue-vs2022-ca1508

Demonstrates an issue with `CA1508` warning.

Compile and see `GenerateWarning.cs` on line 16.

> warning CA1508: 'customer.LastName.Length == 0' is always 'true'. Remove or refactor the condition(s) to avoid dead code.

See [issue in Developer Community](https://developercommunity.visualstudio.com/t/CA1508-reported-incorrectly/1618815),
filed also under [roslyn-analyzers issues](https://github.com/dotnet/roslyn-analyzers/issues/5789).

## Tested with 6.0.200-preview.22055.15

```cmd
dotnet clean
dotnet build
```

Running `dotnet build` (Jan 23 2022) produces this output:

```log
Microsoft (R) Build Engine version 17.1.0-preview-21610-01+96a618ca5 for .NET
Copyright (C) Microsoft Corporation. All rights reserved.

  Determining projects to restore...
  All projects are up-to-date for restore.
  You are using a preview version of .NET. See: https://aka.ms/dotnet-core-preview
  You are using a preview version of .NET. See: https://aka.ms/dotnet-core-preview
  ClassLibrary -> S:\git\issue-vs2022-ca1508\ClassLibrary\bin\Debug\net6.0\ClassLibrary.dll
S:\git\issue-vs2022-ca1508\Program\GenerateWarning.cs(16,14): warning CA1508: 'customer.LastName.Length == 0' is always 'true'. Remove or refactor the condition(s) to avoid dead code. [S:\git\issue-vs2022-ca1508\Program\Program.csproj]
  Program -> S:\git\issue-vs2022-ca1508\Program\bin\Debug\net6.0\Program.dll

Build succeeded.

S:\git\issue-vs2022-ca1508\Program\GenerateWarning.cs(16,14): warning CA1508: 'customer.LastName.Length == 0' is always 'true'. Remove or refactor the condition(s) to avoid dead code. [S:\git\issue-vs2022-ca1508\Program\Program.csproj]
    1 Warning(s)
    0 Error(s)

Time Elapsed 00:00:01.25
```


## Tested with SDK Version 6.0.101

```cmd
dotnet clean
dotnet build
```

Running `dotnet build` (Jan 12 2022) produces this output:

```log
Microsoft (R) Build Engine version 17.0.0+c9eb9dd64 for .NET
Copyright (C) Microsoft Corporation. All rights reserved.

  Determining projects to restore...
  Restored S:\git\tmp\issue-vs2022-ca1508\ClassLibrary\ClassLibrary.csproj (in 218 ms).
  Restored S:\git\tmp\issue-vs2022-ca1508\Program\Program.csproj (in 220 ms).
  ClassLibrary -> S:\git\tmp\issue-vs2022-ca1508\ClassLibrary\bin\Debug\net6.0\ClassLibrary.dll
S:\git\tmp\issue-vs2022-ca1508\Program\GenerateWarning.cs(16,14): warning CA1508: 'customer.LastName.Length == 0' is always 'true'. Remove or refactor the condition(s) to avoid dead code. [S:\git\tmp\issue-vs2022-ca1508\Program\Program.csproj]
  Program -> S:\git\tmp\issue-vs2022-ca1508\Program\bin\Debug\net6.0\Program.dll

Build succeeded.

S:\git\tmp\issue-vs2022-ca1508\Program\GenerateWarning.cs(16,14): warning CA1508: 'customer.LastName.Length == 0' is always 'true'. Remove or refactor the condition(s) to avoid dead code. [S:\git\tmp\issue-vs2022-ca1508\Program\Program.csproj]
    1 Warning(s)
    0 Error(s)

Time Elapsed 00:00:06.08
```
