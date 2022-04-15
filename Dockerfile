FROM mcr.microsoft.com/dotnet/sdk:5.0 as build
WORKDIR /app
COPY . .
RUN dotnet publish -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build /app/out .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet Yapilacaklar.API.dll
