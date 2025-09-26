# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy solution and project files
COPY *.sln ./
COPY src/App/*.csproj ./src/App/

# Restore dependencies
RUN dotnet restore

# Copy all source code
COPY . ./

# Publish the project
RUN dotnet publish src/App/Portfolio.App.csproj -c Release -o out

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copy published output
COPY --from=build /app/out ./

# Expose port 80
EXPOSE 80

# Start the app
ENTRYPOINT ["dotnet", "Portfolio.App.dll"]
