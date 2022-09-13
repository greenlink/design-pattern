# Dojo template for .NET 6 using Docker
A simple template to do Dojo practices with .Net 6 sdk.

## Using it
You must have docker installed to use. If you're on windows, don't forget to start de Docker Desktop application before.

### Linux or macOS
 > docker run --rm -v $(pwd):/app -w /app/Project.Tests mcr.microsoft.com/dotnet/sdk:6.0 dotnet test --logger:trx

### Windows using Linux containers (WSL 2)
 > docker run --rm -v ${pwd}:/app -w /app/Project.Tests mcr.microsoft.com/dotnet/sdk:6.0 dotnet test --logger:trx

 ### Windows using Windows containers
 > docker run --rm -v ${pwd}:C:\app -w C:\app\Project.Tests mcr.microsoft.com/dotnet/sdk:6.0 dotnet test --logger:trx

## Fork
Feel free to fork and create your own project!

## Credits
The idea for this tamplate was copied from [lazaromenezes](https://github.com/lazaromenezes/dotnet-dojo-repl-template), but was adapted to use docker.
