FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

COPY . /app

WORKDIR /app

RUN dotnet restore

RUN dotnet build -c Debug

EXPOSE 5000
EXPOSE 8080

ENV ASPNETCORE_ENVIRONMENT=Development
ENV ASPNETCORE_URLS=http://+:5000

CMD ["dotnet", "watch", "run", "--project", "TalentHubDiscordApi/TalentHubDiscordApi.csproj"]