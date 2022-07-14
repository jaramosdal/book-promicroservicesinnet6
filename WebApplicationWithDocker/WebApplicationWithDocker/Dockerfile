#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["WebApplicationWithDocker/WebApplicationWithDocker.csproj", "WebApplicationWithDocker/"]
RUN dotnet restore "WebApplicationWithDocker/WebApplicationWithDocker.csproj"
COPY . .
WORKDIR "/src/WebApplicationWithDocker"
RUN dotnet build "WebApplicationWithDocker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebApplicationWithDocker.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApplicationWithDocker.dll"]