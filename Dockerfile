FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY Delivery/Delivery.csproj Delivery/
COPY Domain/Domain.csproj Domain/

RUN dotnet restore Delivery/Delivery.csproj

COPY . .
WORKDIR /src/Delivery
RUN dotnet build Delivery.csproj -c Release -o /build
RUN dotnet publish Delivery.csproj -c Release -o /app

FROM microsoft/dotnet:2.1-aspnetcore-runtime AS runtime
WORKDIR /app
COPY --from=build /app .
CMD ["dotnet", "Delivery.dll"]