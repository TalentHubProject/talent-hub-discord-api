FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["TalentHubDiscordApi/TalentHubDiscordApi.csproj", "TalentHubDiscordApi/"]
RUN dotnet restore "TalentHubDiscordApi/TalentHubDiscordApi.csproj"
COPY . .
WORKDIR "/src/TalentHubDiscordApi"
RUN dotnet build "TalentHubDiscordApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TalentHubDiscordApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY ["TalentHubDiscordApi/Assets", "Assets/"]
ENTRYPOINT ["dotnet", "TalentHubDiscordApi.dll"]