Reproduce code of [https://github.com/microsoft/msbuild/issues/1754](https://github.com/microsoft/msbuild/issues/1754)

`dotnet build` shows following error.

```
MSBuildAssemblyLoadIssue>dotnet build
Microsoft (R) Build Engine 16.4.0+e901037fe

MSBuildAssemblyLoadIssue.csproj(21,9): error : Could not load file or assembly 'Microsoft.CodeAnalysis.CSharp, Version=3.4.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35'. Could not find or load a specific file. (0x80131621)
MSBuildAssemblyLoadIssue.csproj(21,9): error :    at MagicOnion.CodeAnalysis.MethodCollector..ctor(String csProjPath, IEnumerable`1 conditinalSymbols, Action`1 logger)
MSBuildAssemblyLoadIssue.csproj(21,9): error :    at MagicOnion.MagicOnionCompiler.GenerateFileAsync(String input, String output, Boolean unuseUnityAttr, String namespace, String conditionalSymbol)
MSBuildAssemblyLoadIssue.csproj(21,9): error :    at MagicOnion.MSBuild.Tasks.MagicOnionGenerator.Execute()
```