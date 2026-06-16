# ---------- BUILD STAGE ----------
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

# copy sln & restore
COPY *.sln ./
COPY Havesh.Common/*.csproj Havesh.Common/
COPY Havesh.Model/*.csproj Havesh.Model/
COPY Havesh.GrainInterfaces/*.csproj Havesh.GrainInterfaces/
COPY Havesh.Grains/*.csproj Havesh.Grains/
COPY Havesh.Silo/*.csproj Havesh.Silo/

RUN dotnet restore Havesh.Silo.sln

# copy all projects
COPY . .

RUN dotnet publish Havesh.Silo/Havesh.Silo.csproj -c Release -o /app/publish

# ---------- RUNTIME STAGE ----------
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app

COPY --from=build /app/publish .

# Network ports for Orleans
EXPOSE 11111
EXPOSE 30000
EXPOSE 8082

# Kestrel ports
EXPOSE 80
EXPOSE 443

ENTRYPOINT ["dotnet", "Havesh.Silo.dll"]
