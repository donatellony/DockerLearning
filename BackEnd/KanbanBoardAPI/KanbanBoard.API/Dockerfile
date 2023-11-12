FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["KanbanBoardAPI/KanbanBoardAPI.csproj", "KanbanBoardAPI/"]
RUN dotnet restore "KanbanBoardAPI/KanbanBoardAPI.csproj"
COPY . .
WORKDIR "/src/KanbanBoardAPI"
RUN dotnet build "KanbanBoardAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "KanbanBoardAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "KanbanBoardAPI.dll"]
