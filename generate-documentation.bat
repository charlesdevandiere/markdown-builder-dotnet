@echo off
dotnet build .\src\MarkdownBuilder\MarkdownBuilder.csproj -c Release
dotnet tool run xmldoc2md .\src\MarkdownBuilder\bin\Release\netstandard2.0\MarkdownBuilder.dll .\docs\api --github-pages --back-button
