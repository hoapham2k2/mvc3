# Start with the official .NET Core 3.1 SDK image
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env

# Set the working directory in the container
WORKDIR /mvc3

# Copy the project file and restore the dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the remaining source code
COPY . ./

# Build the application
RUN dotnet publish -c Release -o out

# Start with a lightweight runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

# Set the working directory in the container
WORKDIR /app

# Copy the output of the build from the previous stage
COPY --from=build-env /app/out .

# Set the command to start the application
CMD ["dotnet", "mvc3.dll"]
