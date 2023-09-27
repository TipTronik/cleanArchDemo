FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Demo.Host/Demo.Host.csproj", "Demo.Host/"]
RUN dotnet restore "Demo.Host/Demo.Host.csproj"
COPY . .
WORKDIR "/src/Demo.Host"
RUN dotnet build "Demo.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Demo.Host.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Demo.Host.dll"]
