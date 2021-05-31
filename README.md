# Base Project to work with VS2019 .Net5.0 and Postgresql
This project has just the basic configuration to connect to postgresql from .Net5.0

# To start
Change your connection string and remove the example model, DTO and controller (do not forget to remove the model from the context)

# How to change the connection string
Edit connection chain "DefaultConnection" in [appsetings.json](https://addlink)

# How to rename the project 
To rename the solution follow the next steps ([source (go give Contango an upvote ;) )](https://stackoverflow.com/questions/2043618/proper-way-to-rename-solution-and-directories-in-visual-studio))
1. Close Visual Studio.
2. Imagine you want to rename from BasePostgresqlDotNetApp to Project1.
3. Rename the folder from BasePostgresqlDotNetApp to Project1 using Windows Explorer.
4. In the BasePostgresqlDotNetApp.sln file, edit all instances of BasePostgresqlDotNetApp to be Project1, using a text editor like NotePad.
5. Rename the BasePostgresqlDotNetApp.sln, BasePostgresqlApp.csproj.user and BasePostgresqlApp.csproj files to Project1.sln, Project1.csproj.user and Project1.csproj respectively
6. Restart Visual Studio

# How to make migrations 
You can migrate as in a normal .net app
To do so go to your NuGet console and execute the folowing code (make sure to remove the example model and controller first)
1. Execute `add-migration initial` where initial is your migration name
2. Execute `update-database` to apply the changes to the database


# Based on the tutorial
[Tutorial en faun.pub](https://faun.pub/asp-net-core-entity-framework-core-with-postgresql-code-first-d99b909796d7)