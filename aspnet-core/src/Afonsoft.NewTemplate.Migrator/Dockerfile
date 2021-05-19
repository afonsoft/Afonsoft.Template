#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/Afonsoft.NewTemplate.Migrator/Afonsoft.NewTemplate.Migrator.csproj", "src/Afonsoft.NewTemplate.Migrator/"]
COPY ["src/Afonsoft.NewTemplate.EntityFrameworkCore/Afonsoft.NewTemplate.EntityFrameworkCore.csproj", "src/Afonsoft.NewTemplate.EntityFrameworkCore/"]
COPY ["src/Afonsoft.NewTemplate.Core/Afonsoft.NewTemplate.Core.csproj", "src/Afonsoft.NewTemplate.Core/"]
COPY ["src/Afonsoft.NewTemplate.Core.Shared/Afonsoft.NewTemplate.Core.Shared.csproj", "src/Afonsoft.NewTemplate.Core.Shared/"]
RUN dotnet restore "src/Afonsoft.NewTemplate.Migrator/Afonsoft.NewTemplate.Migrator.csproj"
COPY . .
WORKDIR "/src/src/Afonsoft.NewTemplate.Migrator"
RUN dotnet build "Afonsoft.NewTemplate.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Afonsoft.NewTemplate.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Afonsoft.NewTemplate.Migrator.dll"]
