FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["HaveshApp/HaveshApp.csproj", "HaveshApp/"]
COPY ["Havesh.Domain/Havesh.Domain.csproj", "Havesh.Domain/"]
COPY ["Havesh.GrainInterfaces/Havesh.GrainInterfaces.csproj", "Havesh.GrainInterfaces/"]
COPY ["Havesh.Model/Havesh.Model.csproj", "Havesh.Model/"]
COPY ["Havesh.OrleansClient/Havesh.OrleansClient.csproj", "Havesh.OrleansClient/"]
COPY ["Havesh.Common/Havesh.Common.csproj", "Havesh.Common/"]
COPY ["Havesh.Grains/Havesh.Grains.csproj", "Havesh.Grains/"]
COPY ["Havesh.Application/Havesh.Application.csproj", "Havesh.Application/"]
RUN dotnet restore "HaveshApp/HaveshApp.csproj"
COPY . .
WORKDIR "/src/HaveshApp"
RUN dotnet build "HaveshApp.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "HaveshApp.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
# Copy the startup script
COPY HaveshApp/start.sh .
COPY HaveshApp/file.env .

# Ensure the startup script is executable
RUN chmod +x start.sh

# Set the entry point to the startup script
ENTRYPOINT ["./start.sh"]
