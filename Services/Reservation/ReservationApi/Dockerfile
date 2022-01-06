#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
#EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Services/Reservation/ReservationApi/ReservationApi.csproj", "Services/Reservation/ReservationApi/"]
COPY ["Services/Reservation/ReservationService/ReservationService.csproj", "Services/Reservation/ReservationService/"]
COPY ["Services/Reservation/ReservationInfrastructure/ReservationInfrastructure.csproj", "Services/Reservation/ReservationInfrastructure/"]
COPY ["Services/Reservation/ReservationTypes/ReservationTypes.csproj", "Services/Reservation/ReservationTypes/"]
RUN dotnet restore "Services/Reservation/ReservationApi/ReservationApi.csproj"
COPY . .
WORKDIR "/src/Services/Reservation/ReservationApi"
RUN dotnet build "ReservationApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ReservationApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ReservationApi.dll"]