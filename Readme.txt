== Proceso de Ejecucion:

    Es necesario tener instalado el .NET version 7

    1. Limpiar el proyecto: dotnet clean
    2. Compilar el proyecto: dotnet build
    3. Ejecutar el proyecto: dotnet run

    los servicios se exponen por el puerto:
    http://localhost:5045/

    El servicio para listar las personas que han realizado la compra en la empresa ABC es:

    Metodo GET:  http://localhost:5045/persona

    
    El servicio para agregar una nueva persona que realiza la compra en la empresa ABC es:

    Metodo POST: http://localhost:5045/persona 
    Body JSON: {
        "codigo": ,
        "identificacion": "",
        "nombres": "",
        "apellidos": "",
        "telefono": "",
        "direccion": "",
        "perfilCompra": ,
        "valorCompra":
    } 