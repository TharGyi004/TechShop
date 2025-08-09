# 1. Build stage using .NET 8.0 preview SDK
FROM mcr.microsoft.com/dotnet/sdk:8.0-preview AS build
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# 2. Runtime stage using .NET 8.0 preview runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0-preview AS runtime
WORKDIR /app
COPY --from=build /app/out ./

# Expose port 5000 (or your configured port)
EXPOSE 5000

ENTRYPOINT ["dotnet", "TechShop.dll"]
