# CodeFirstRelation

This project demonstrates a **Code First** approach using **ASP.NET Core 6** and **Entity Framework Core**. It manages two entities: **Users** and **Posts**.

## Features
- Code First database creation.
- CRUD operations for Users and Posts.
- SQL Server as the database.

## Entities
- **User**: Id, Username, Email.
- **Post**: Id, Title, Content, UserId (foreign key).

## Getting Started

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server or LocalDB](https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-2019-setup?view=sql-server-ver15)

### Installation
1. Clone the repo:  
   `https://github.com/AhmetSulu/CodeFirstRelation.git`

2. Update `appsettings.json` with your SQL Server connection.

3. Run migrations:  
   `dotnet ef migrations add InitialCreate`  
   `dotnet ef database update`

4. Start the app:  
   `dotnet run`
   
## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact

For any questions or support, please email ahmet.sulu1993@gmail.com
