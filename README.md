# ASP.NET Core Web API & MSSQL & Swagger

Teknik dökümana ulaşmak için <a href="Docs/Index.md">tıklayınız</a>.

### Kullanılan Teknolojiler
- .Net Core 5
- Repository
- UnitOfWork
- Entity Framework
- Injection
- Swagger (Authentication mevcut)
- Veritabanı MSSQL

### Settings (appsettings.json)
```
Connection String:
    ConnectionStrings.SqlConnectionString
    Default: Server=N-UYGUR;Database=YapilacaklarDB;User ID=sa;Password=Necdet2021;
Swagger Basic Authentication Username:
    BasicAuthentication.Username
    Default: admin
Swagger Basic Authentication Password:
    BasicAuthentication.Password
    Default: Necdet2021
```
### Database
![YapilacaklarDB](Docs/YapilacaklarDB.jpg "YapilacaklarDB")

### Commands
```
Add-Migration Initial
Update-Database
```

### Mac / Linux / Rider
```
dotnet tool install --global dotnet-ef
cd ./Yapilacaklar.API
dotnet ef database update
```
