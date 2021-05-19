#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/Afonsoft.NewTemplate.Web.Host/Afonsoft.NewTemplate.Web.Host.csproj", "src/Afonsoft.NewTemplate.Web.Host/"]
COPY ["src/Afonsoft.NewTemplate.Web.Core/Afonsoft.NewTemplate.Web.Core.csproj", "src/Afonsoft.NewTemplate.Web.Core/"]
COPY ["src/Afonsoft.NewTemplate.Application/Afonsoft.NewTemplate.Application.csproj", "src/Afonsoft.NewTemplate.Application/"]
COPY ["src/Afonsoft.NewTemplate.Application.Shared/Afonsoft.NewTemplate.Application.Shared.csproj", "src/Afonsoft.NewTemplate.Application.Shared/"]
COPY ["src/Afonsoft.NewTemplate.Core.Shared/Afonsoft.NewTemplate.Core.Shared.csproj", "src/Afonsoft.NewTemplate.Core.Shared/"]
COPY ["src/Afonsoft.NewTemplate.Core/Afonsoft.NewTemplate.Core.csproj", "src/Afonsoft.NewTemplate.Core/"]
COPY ["src/Afonsoft.NewTemplate.EntityFrameworkCore/Afonsoft.NewTemplate.EntityFrameworkCore.csproj", "src/Afonsoft.NewTemplate.EntityFrameworkCore/"]
COPY ["src/Afonsoft.NewTemplate.GraphQL/Afonsoft.NewTemplate.GraphQL.csproj", "src/Afonsoft.NewTemplate.GraphQL/"]
RUN dotnet restore "src/Afonsoft.NewTemplate.Web.Host/Afonsoft.NewTemplate.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/Afonsoft.NewTemplate.Web.Host"
RUN dotnet build "Afonsoft.NewTemplate.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Afonsoft.NewTemplate.Web.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Afonsoft.NewTemplate.Web.Host.dll"]
