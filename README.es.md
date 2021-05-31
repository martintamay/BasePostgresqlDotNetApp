# Proyecto base para trabajar con VS2019 .Net5.0 y Postgresql
Este proyecto tiene la configuración básica para conectar a postgresql con .Net5.0

# Para comenzar
Change yout connection string and remove the example model, DTO and controller (do not forget to remove the model from the context)
Cambia tu connection string y elimina los modelos, dto y controller de ejemplo que trae el proyecto (no te olvides de remover el modelo del contexto)

# Como cambiar el connection string
Edita el connection string en "Default connection" en [appsetings.json](https://addlink)

# Como renombrar el proyecto
Para renombrar la solución sigue los siguientes pasos ([fuente (ve a dar a Contango un upvote ;) )](https://stackoverflow.com/questions/2043618/proper-way-to-rename-solution-and-directories-in-visual-studio))
1. Cierra tu Visual Studio.
2. Imagina que quieres remobrar el proyecto de BasePostgresqlDotNetApp a Proyecto1.
3. Renombra la carpeta de BasePostgresqlDotNetApp a Proyecto1 en tu explorador de archivos
4. En el BasePostgresqlDotNetApp.sln renombra todas las apariciones de BasePostgresqlDotNetApp a Proyecto1 en un editor como NotePad
5. Renombra los archivos BasePostgresqlDotNetApp.sln, BasePostgresqlApp.csproj.user y BasePostgresqlApp.csproj a Project1.sln, Project1.csproj.user y Project1.csproj respectivamente.
6. Reiniciar tu Visual Studio

# Como hacer migraciones
Puedes hacer migraciones como en cualquier app de .net normal
Para hacerlo ve a tu consola de NeGet y ejecuta los siguientes comandos (asegúrate de eliminar primero los modelos y controladores de ejemplo)
1. Ejecuta `add-migration initial` donde initial es el nombre de tu migración
2. Ejecuta `update-database` para aplicar los cambios a la base de datos


# Basado en el siguiente tutorial
[Tutorial en faun.pub](https://faun.pub/asp-net-core-entity-framework-core-with-postgresql-code-first-d99b909796d7)