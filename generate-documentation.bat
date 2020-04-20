@echo off
dotnet publish .\src\MarkdownBuilder\MarkdownBuilder.csproj -c Release -o out
dotnet tool run xmldoc2md .\out\MarkdownBuilder.dll .\docs\api
echo.
echo   [warn] Check line breaks
echo.
