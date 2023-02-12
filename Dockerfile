# Define the base image to use
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env

# Set the working directory to /app
WORKDIR /app

# Copy the project file and restore dependencies
COPY mvc3.csproj .
RUN dotnet restore

# Copy the rest of the application code
COPY . .

# Build the application and publish to a folder
RUN dotnet publish -c Release -o out

# Define the runtime image to use
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

# Set the working directory to /app
WORKDIR /app

# Copy the application from the build environment to the runtime environment
COPY --from=build-env /app/out .

# Start the application
ENTRYPOINT ["dotnet", "mvc3.dll"]
