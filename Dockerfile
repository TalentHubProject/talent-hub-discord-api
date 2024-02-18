FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base

WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
COPY . /src
WORKDIR /src
RUN dotnet restore
RUN dotnet build -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=build /app .

EXPOSE 80

ENV ASPNETCORE_ENVIRONMENT=Production
ENV ASPNETCORE_URLS=http://+:80

CMD ["dotnet", "TalentHubDiscordApi.dll"]