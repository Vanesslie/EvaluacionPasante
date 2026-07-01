EvaluacionPasante

El presente proyecto corresponde a una evaluacion para optar a la posicion de pasante de desarrollo. Las tecnologías que se piden en esta evaluacion son: Transact SQL, .Net 8 - c#, Github, html y css.

Dentro del limite de tiempo establecido, se completo: la creacion de la base de datos, insercion en esta, configuraciones generales de la API, y enpoints para la tabla producto. dichos endpoints son: Get, GetId, Post, Delete.

Dicho esto, considerando el limite de tiempo, se aplicaron los conceptos y practicas no solo mas sencillas, sino que también las más ágiles. por ejemplo: se pasa por alto utilizar DTOs, interfaces, etc. y es uno de los principales puntos que se podran mejorar a futuro.

Sin mas que mencionar como introduccion, ademas de que cualquier comentario y sugerencia es bienvenido, agradezco su atencion en esta corta aclaración.

--Configuraciones

En la configuración a la conexión de la Base de Datos
===

"ConnectionStrings": {

&#x20; "DefaultConnection": "Server=localhost,1433;Database=TEST;User Id=sa;Password=TU\_PASSWORD;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=True;"

}

Esta es la cadena de conexión usual, sin embargo, en este proyecto configure la Base de datos para tener autenticación de Windows, por lo que no es necesario utilizar Id ni password. en caso de que no se desee trabajar de esta misma manera, utilizar esta cadena de texto en su lugar, y reemplazar los datos con los que corresponden.

--instrucciones

