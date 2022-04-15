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

### PM Commands
```
CODE FIRST:
Add-Migration Initial
Update-Database

DATABASE FIRST:
Scaffold-DbContext "Server=XXX; Database=XXX; User ID=XXX; Password=XXX;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Entities
```

### Mac / Linux / Rider / BASH
```
CODE FIRST:
dotnet tool install --global dotnet-ef
cd ./Yapilacaklar.API
dotnet ef database update

DATABASE FIRST:
cd ./Yapilacaklar.API
dotnet ef dbcontext scaffold "Server=XXX;Database=XXX;User ID=XXX;Password=XXX;" Microsoft.EntityFrameworkCore.SqlServer -o Entities -t BlogPost
```

### BlogPost Tablo
```sql
CREATE TABLE [dbo].[BlogPost] ( 
    [BlogPostID]  int IDENTITY(1,1) NOT NULL,
    [Baslik] nvarchar(max) NULL,
    [Icerik] nvarchar(max) NULL,
    CONSTRAINT [PK_BlogPost] PRIMARY KEY CLUSTERED([BlogPostID])
    WITH FILLFACTOR = 80 ON [PRIMARY])
ON [PRIMARY]
    TEXTIMAGE_ON [PRIMARY]
    WITH (
        DATA_COMPRESSION = NONE
    )
GO
```

### HEROKU DEPLOY
```
docker build -t y1:v1 .
# docker run -p 5000:81 y1:v1
docker tag y1:v1 registry.heroku.com/yapilacaklarapi/web
heroku container:login
docker push registry.heroku.com/yapilacaklarapi/web
heroku container:release web --app yapilacaklarapi
heroku logs --tail --app yapilacaklarapi
```

[https://yapilacaklarapi.herokuapp.com/swagger](https://yapilacaklarapi.herokuapp.com/swagger)

[https://yapilacaklarapi.herokuapp.com/api/Kullanici](https://yapilacaklarapi.herokuapp.com/api/Kullanici)

![Heroku](README_herokutest.jpg)
