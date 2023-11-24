FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Segundo/Segundo.csproj", "Segundo/"]
RUN dotnet restore "Segundo/Segundo.csproj"
COPY . .
WORKDIR "/src/Segundo"
RUN dotnet build "Segundo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Segundo.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Segundo.dll"]
