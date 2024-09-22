#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Havesh.Silo/Havesh.Silo.csproj", "Havesh.Silo/"]
COPY ["Havesh.Common/Havesh.Common.csproj", "Havesh.Common/"]
COPY ["Havesh.Grains/Havesh.Grains.csproj", "Havesh.Grains/"]
COPY ["Havesh.Domain/Havesh.Domain.csproj", "Havesh.Domain/"]
COPY ["Havesh.Model/Havesh.Model.csproj", "Havesh.Model/"]
COPY ["Havesh.GrainInterfaces/Havesh.GrainInterfaces.csproj", "Havesh.GrainInterfaces/"]
RUN dotnet restore "Havesh.Silo/Havesh.Silo.csproj"
COPY . .
WORKDIR "/src/Havesh.Silo"
RUN dotnet build "Havesh.Silo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Havesh.Silo.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Havesh.Silo.dll"]