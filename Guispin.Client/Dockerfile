# Guispin.Client/Dockerfile

# --- Build stage ---
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy solution + projects
COPY Guispin.sln ./
COPY Guispin.Client/Guispin.Client.csproj Guispin.Client/
COPY Guispin.Shared/Guispin.Shared.csproj Guispin.Shared/

# Restore dependencies
RUN dotnet restore Guispin.Client/Guispin.Client.csproj

# Copy everything else and build
COPY . .
RUN dotnet publish Guispin.Client/Guispin.Client.csproj -c Release -o /app/publish

# --- Runtime stage ---
FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=build /app/publish/wwwroot .
# Replace default nginx config with Blazor-friendly one
COPY Guispin.Client/nginx.conf /etc/nginx/conf.d/default.conf
