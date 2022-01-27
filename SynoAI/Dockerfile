FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
RUN apt-get update && apt-get install -y libgdiplus
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["SynoAI/SynoAI.csproj", "SynoAI/"]
RUN dotnet restore "SynoAI/SynoAI.csproj"
COPY . .
WORKDIR "/src/SynoAI"
RUN dotnet build "SynoAI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SynoAI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SynoAI.dll"]