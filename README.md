# CodeGeneration.Roslyn problem repro

The problem in question is raised e.g. here: https://github.com/AArnott/CodeGeneration.Roslyn/issues/106

The generation tool cannot load dependencies of the generator, specifically `Microsoft.CodeAnalysis.CSharp.Workspaces` 2.9.0.

The dependency is added on `with-dependency` branch.

The result is that the project `Library` that has a `Class1Abc` generated fails to build (because that class is not generated).
