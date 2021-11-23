FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
LABEL version="1.0" maintainer="Rodolfo Dias"		
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["TheDonut.Api/TheDonut.Api.csproj", "TheDonut.Api/"]
RUN dotnet restore "TheDonut.Api/TheDonut.Api.csproj"
COPY . .
WORKDIR "/src/TheDonut.Api"
RUN dotnet build "TheDonut.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TheDonut.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TheDonut.Api.dll"]