# BancoPagaTodo -Prueba tecnica

## Para hacer uso de el proyecto  realiza lo siguiente 
- Clona el repositorio de la liga
~~~ 
git clone https://github.com/usuario/ChallengeNet.git
~~~

- Ingresa a el repositorio con el siguiente comando
  ~~~
  cd ChallengeNet
  ~~~

- Restaura los paquetes de NuGet:
  ~~~
  dotnet restore
  ~~~
  

# ****** Proyecto Minimal API
Este proyecto es una minimal API desarrollada en .NET La cual  realizara operaciones basicas (Suma , Resta, Multiplicacion, Divicion)

## Requisitos Previos

Asegúrate de tener instalados los siguientes programas y versiones:

- Requiere [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) o superior..
- [Visual Studio](https://visualstudio.microsoft.com/) o [VS Code](https://code.visualstudio.com/) (opcional, pero recomendado para editar el código).


## Características

- End points para cada operacion 
- Implementacion de inyeccion de dependencia.
- Los end point reciben una entidad (Valores_Operacion)
- Ejemplo de la estructura
~~~
{
  "Numero1": 10.00,
  "Numero2": 0.00
}
~~~

 ## Uso de la Minimal API
- POST /api/Suma
- POST /api/Resta
- POST /api/Multiplicacion
- POST /api/Dividir


# ****** Proyecto Crud Employees
Este proyecto es una API desarrollada en .NET para manejar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) sobre una tabla de empleados. La API utiliza Entity Framework Core para interactuar con SQL Server y sigue el patrón de repositorio para la separación de lógica de negocio.

## Características

- CRUD completo para empleados.
- Implementación del patrón de repositorio
- inyeccion de dependencias.
- Uso de Entity Framework Core
- Validaciones de modelo usando data annotations.
- Manejo de Excepciones

## Requisitos Previos

Asegúrate de tener instalados los siguientes programas y versiones:

- Requiere [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) o superior..
- [SQL Server](https://www.microsoft.com/es-es/sql-server/sql-server-downloads) (con una instancia configurada).
- [Visual Studio](https://visualstudio.microsoft.com/) o [VS Code](https://code.visualstudio.com/) (opcional, pero recomendado para editar el código).
- Acceso a internet para restaurar paquetes NuGet.


  
## Configuración del Entorno
Configura la cadena de conexión en `appsettings.json` o como variable de entorno `Connection_db` en caso de usar configuraciones sensibles.
~~~
{
  "ConnectionStrings": {
    "Connection_db": "Server=DESKTOP-3JI0N09\\SQLEXPRESS;Database=challenge_net;User Id=dev_lara;Password=dev_lara2024;TrustServerCertificate=True;"
  }
}
~~~
## Configurar la Base de Datos
- Asegúrate de que SQL Server esté ejecutándose y de que tienes una base de datos llamada ```challenge_net```
- También puedes generar la base de datos automáticamente con las migraciones de EF Core con el siguiente comanda verificando que  el archivo `appsettings.json` tenga las credenciales de acceso a sql correctas :

- inicializar  una migracion
~~~
   Add-Migration Inicial
~~~

  - Actualiza la base de datos  con
~~~
   Update-Database
~~~
##Uso de Api Crud de empleados

# Documentación de la API: EmployeesController

## Descripción

Este controlador permite gestionar empleados en la aplicación. Proporciona operaciones para listar, crear, editar, eliminar y buscar empleados.

## Base URL
~~~
http://tu-api-url/api/employees
~~~

## Endpoints

### 1. Listar Empleados

- **Método:** `GET`
- **Ruta:** `/api/employees`
- **Descripción:** Obtiene una lista de todos los empleados.
- **Respuesta Exitosa (200 OK):**
~~~
{
    "data": [
        {
            "employeeId": "1fbbae48-c560-4078-97ed-ca577360abc5",
            "firstName": "Ezequiel",
            "lastName": "Lara Herrera",
            "salary": 320050.50
        },
        .....
    ]
}
~~~
### 2. Buscar Empleado por ID

- **Método:** `GET`
- **Ruta:** `/api/employees/{employeeId}`
- **Descripción:** Obtiene un empleado por su identificador.
- **Respuesta Exitosa (200 OK):**
~~~
{
    "message": "Elemento encontrado",
    "data": {
        "employeeId": "1fbbae48-c560-4078-97ed-ca577360abc5",
        "firstName": "Ezequiel",
        "lastName": "Lara Herrera",
        "salary": 320050.50
    }
}
~~~
- **Respuesta Incorrecta (400 Bad Request):**
~~~
Ha ocurrido un error: Empleado no encontrado.
~~~
### 3. Inserta un empleado

- **Método:** `POST`
- **Ruta:** `/api/employees`
- **Descripción:** Genera un nuevo registro de empleado.
- **Respuesta Exitosa (200 OK):**
~~~
  {
    "message": "Registro creado",
    "data": {
        "employeeId": "f605e228-a04f-4535-8b17-8fcab10b1367",
        "firstName": "test otro nombre2",
        "lastName": "Lara",
        "salary": 320.50
    }
}
~~~
- **Respuesta Incorrecta (400 Bad Request):**
~~~
{
    "type": "https://tools.ietf.org/html/rfc9110#section-15.5.1",
    "title": "One or more validation errors occurred.",
    "status": 400,
    "errors": {
        "LastName": [
            "El LastName es requerido",
            "El LastName debe tener como minimo 3 caracteres"
        ]
    },
    "traceId": "00-1f9686e8708f0ae29e15be4e17488365-854126f509b6d56d-00"
}
~~~
### 3. Elimina un empleado

- **Método:** `DELETE`
- **Ruta:** `/api/employees`
- **Descripción:** Elimina un empleado.
- **Respuesta Exitosa (200 OK):**
~~~
   Registro Eliminado  f605e228-a04f-4535-8b17-8fcab10b1367
~~~  
- **Respuesta Incorrecta (400 Bad Request):**
~~~
  Ha ocurrido un error: Empleado no encontrado.
~~~
### 3. Actualiza un empleado

- **Método:** `PUT`
- **Ruta:** `/api/employees`
- **Descripción:** Actualiza el registro de empleado.
- **Respuesta Exitosa (200 OK):**
~~~
{
    "message": "Registro modificado",
    "data": {
        "employeeId": "40acc137-de34-44a7-a532-950201abd7be",
        "firstName": "Ezequiel Lara modified",
        "lastName": "Herrera",
        "salary": 322000
    }
}
~~~
- **Respuesta Incorrecta (400 Bad Request):**
~~~
Ha ocurrido un error :Empleado no encontrado.
~~~





