EvaluacionPasante

En la configuración a la conexión de la Base de Datos
===

"ConnectionStrings": {

&#x20; "DefaultConnection": "Server=localhost,1433;Database=TEST;User Id=sa;Password=TU\_PASSWORD;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=True;"

}

Esta es la cadena de conexión usual, sin embargo, en este proyecto configure la Base de datos para tener autenticación de Windows, por lo que no es necesario utilizar Id ni password. en caso de que no se desee trabajar de esta misma manera, utilizar esta cadena de texto en su lugar, y reemplazar los datos con los que corresponden.

