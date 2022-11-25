# NetCore-Posgres

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)

## Tecnologías 

Tecnologías utilizadas en el projecto:

- [NetCore6] - Plataforma de desarrollo de Microsoft
- [PostgreSQL] - Base de datos relacional

## Instalación

Requiere net core [.NET](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) v6.0.
Requiere PsstgreSQL [postgresql](https://www.postgresql.org/download/).
Requiere EF Core Tools [EFCoreTools](https://learn.microsoft.com/en-us/ef/core/cli/dotnet).

```sh
cd projectFolder
dotnet build
```

Ralizar la migración...

```sh
dotnet ef migrations add "initial_migration"
dotnet ef database update
```

## Nuget Package Manager

El web API esta utilizando los siguientes paquetes.

| Plugin | README |
| ------ | ------ |
| Npgsql | dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 6.0.7 |
| Desing | dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.11 |
| Tools | dotnet add package Microsoft.EntityFrameworkCore.Tools --version 6.0.11 |

## License

MIT
