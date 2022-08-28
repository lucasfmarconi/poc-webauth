#Getting started

There are two different contexts to this application.

1 - Generate migration for the first one (Web Application)

'
cd POC.WebAuth.Web
dotnet ef migrations add NAMEOFMIGRATION --context ApplicationDbContext --verbose
dotnet ef database update --context ApplicationDbContext --verbose
'

2 - Generate migration for the authentication project (Class Library)

'
cd POC.WebAuth.Authentication
dotnet ef migrations add NAMEOFMIGRATION --context AuthenticationDbContext --verbose --startup-project ..\POC.WebAuth.Web\POC.WebAuth.Web.csproj
dotnet ef database update --context AuthenticationDbContext --verbose --startup-project ..\POC.WebAuth.Web\POC.WebAuth.Web.csproj
'