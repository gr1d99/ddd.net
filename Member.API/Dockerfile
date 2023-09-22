FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Member.API/Member.API.csproj", "Member.API/"]
RUN dotnet restore "Member.API/Member.API.csproj"
COPY . .
WORKDIR "/src/Member.API"
RUN dotnet build "Member.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Member.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Member.API.dll"]
