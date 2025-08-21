# Guispin.Server/Dockerfile

# --- Build stage ---
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy solution + projects
COPY Guispin.sln ./
COPY Guispin.Server/Guispin.Server.csproj Guispin.Server/
COPY Guispin.Shared/Guispin.Shared.csproj Guispin.Shared/

# Restore dependencies
RUN dotnet restore Guispin.Server/Guispin.Server.csproj

# Copy everything else and build
COPY . .
RUN dotnet publish Guispin.Server/Guispin.Server.csproj -c Release -o /app/publish

# --- Runtime stage ---
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Guispin.Server.dll"]
