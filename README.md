Instrucciones
-------------
1.	Abrir la solucion.
2.	Compilar la solucion (automáticamente dará inicio a la descarga de los paquetes desde nuget y posteriormente compilará).
3.	Ejecutar/Depurar la aplicación.
4.	Es recomendable usar en paralelo Postman o similar para consultar con mayor facilidad los servicios web api de la aplicación.

Notas
-----
1.	URL's de servicio USUARIOS > http://localhost:8080/MyResftfullApp/Usuarios, a través del cual se pueden ejecutar los metodos http GET, POST, PUT y DELETE propios de una Api Rest.
2.	URL's de servicio COTIZACION > http://localhost:8080/MyResftfullApp/cotizacion/. Recibe tres (03) posibles parámetros: peso, real y dolar.
3.	La base de datos es de tipo LocalDB, por lo cual se encuentra asociada a la aplicación en la ruta \MyResftfullApp\App.WebApi\App_Data\myrestfulapp-20181204100000.mdf
4.	La tabla Usuarios ubicada en la base de datos BDMyRestFulApp asociada, contiene tres (03) registros pre-cargados para su utilización en pruebas.
