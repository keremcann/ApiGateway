#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
#EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Services/Contact/ContactApi/ContactApi.csproj", "Services/Contact/ContactApi/"]
COPY ["Services/Contact/ContactService/ContactService.csproj", "Services/Contact/ContactService/"]
COPY ["Services/Contact/ContactInfrastructure/ContactInfrastructure.csproj", "Services/Contact/ContactInfrastructure/"]
COPY ["Services/Contact/ContactTypes/ContactTypes.csproj", "Services/Contact/ContactTypes/"]
RUN dotnet restore "Services/Contact/ContactApi/ContactApi.csproj"
COPY . .
WORKDIR "/src/Services/Contact/ContactApi"
RUN dotnet build "ContactApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ContactApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ContactApi.dll"]