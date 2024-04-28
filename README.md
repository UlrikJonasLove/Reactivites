# Reactivites
Social network written in React with MobX and ASP.NET Core 

## Clean Architecture
### Api/Server project
Recieves HTTP request and respond to them - Has connection to Application project
### Application project 
Processes the business logic - Has connection to Domain project
### Domain project
Contains the business entities and it is the centre of everything - Has no connection to any other project
### Persistance project
Provides the database and translates the code into SQL queries with entity framework - Has connection to Domain and Application projects
