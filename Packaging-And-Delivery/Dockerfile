
FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Packaging-And-Delivery/Packaging-And-Delivery.csproj", "Packaging-And-Delivery/"]
RUN dotnet restore "Packaging-And-Delivery/Packaging-And-Delivery.csproj"
COPY . .
WORKDIR "/src/Packaging-And-Delivery"
RUN dotnet build "Packaging-And-Delivery.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Packaging-And-Delivery.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Packaging-And-Delivery.dll"]
