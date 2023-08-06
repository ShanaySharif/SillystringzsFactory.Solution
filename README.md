### Dr. Silly Stringz Factory

# By: Shankaron Mohamed (Shanay)
##Description
The Dr. Silly Stringz Factory presents an MVC web application designed to oversee a roster of engineers and machines, determining the authorization of engineers to operate specific machines. This showcases adeptness in executing database migrations and effectively handling intricate many-to-many associations.

## Technologies Used
- C#
- .NET6 SDK
- ASP.NET Core MVC
- EF Core
- SQL
- HTML
- CSS
- Markdown
- Razor
- jQuery
## Setup
- .NET6
- MySQL
- MySQL Workbench
- VS Code
- In the terminal run these commands in order:
$ git clone SillystringzsFactory.Solution
- cd SillystringzsFactory.Solution
- $ touch .gitignore 2. copy/paste this into the .gitignore file:
obj
bin
appsettings.json

- Navigate to this project's production directory called "Factory" with $ cd Factory.
Within the production directory run the command $ touch appsettings.json.
-In the appsettings.json file, paste in the following code, replacing [user-id] and [password] with your username and password for MySQL Workbench. (Remember to remove the square brackets when inputting your details): { `"ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=factory;uid=[user-id];pwd=[password];" } }``
Within the production directory "Factory", run $ dotnet ef database update to instantiate the database.
- Still within the production directory, run $ dotnet watch run in the command line to launch the application in development mode in a browser, and interact with the application.
##Known Bugs
- None at this time
MIT License
Copyright (c) 2023 Shankaron Mohamed