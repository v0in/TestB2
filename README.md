# TestB2
Ensure you have the following installed:

- **.NET SDK 9.0**  
- **Node.js (LTS version)**  
- **SQLite** (included in .NET Core)  
- **Git** (for cloning the repository)

#How to run
InventoryAPI
- Restore dependencies by running: dotnet restore
- dotnet ef database update  # Apply database migrations
- dotnet run to run backend
  
inventory-client
- npm install
- npm start

Port conflicts? 
Change ports in appsettings.json (backend) or package.json (frontend).
