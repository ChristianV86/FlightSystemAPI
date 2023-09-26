# Solución API para la Gestión de Rutas de Vuelo

Esta es una solución API desarrollada para gestionar rutas de vuelo a través del mundo. Permite a los usuarios consultar rutas de vuelo entre un origen y un destino especificados y calcular el precio total del viaje. La solución consta de tres capas: API, Business y DataAccess.

## Problema 1 - Modelado de Clases

Se ha diseñado un modelo de clases para trabajar con vuelos en la aplicación:

- `Journey`: Representa una ruta de viaje con propiedades como vuelos, origen, destino y precio de la ruta.
- `Flight`: Representa un vuelo individual con información sobre transporte, origen, destino y precio.
- `Transport`: Representa los detalles del transporte del vuelo, incluyendo el transportista y el número de vuelo.

## Problema 2 - Obtener Datos Externos

Se ha implementado un método para obtener datos de vuelo de una API externa. Los datos se almacenan en las tablas `Flights` y `Transports` en la base de datos.

## Problema 3 - Calcular Ruta y Responder al Usuario

Se ha expuesto un API con un método GET para calcular rutas de viaje basadas en el origen y el destino proporcionados por el usuario. El precio total del viaje se calcula sumando los precios de los vuelos en la ruta.

La respuesta se entrega en el siguiente formato:

```json
{
  "Journey": {
    "Origin": "MZL",
    "Destination": "BCN",
    "Price": 2000.0,
    "Flights": [
      {
        "Origin": "MZL",
        "Destination": "JFK",
        "Price": 1000.0,
        "Transport": {
          "FlightCarrier": "AV",
          "FlightNumber": "8020"
        }
      },
      {
        "Origin": "JFK",
        "Destination": "BCN",
        "Price": 1000.0,
        "Transport": {
          "FlightCarrier": "AV",
          "FlightNumber": "8040"
        }
      }
    ]
  }
}

# Base de Datos
Se utiliza una base de datos llamada FlightSystemBD con cuatro tablas: Transport, Flight, Journey y FlightJourney para almacenar y relacionar los datos de vuelo y las rutas de viaje.

Inyección de Dependencias y AutoMapper
Se ha implementado la inyección de dependencias para separar las responsabilidades en la solución. AutoMapper se utiliza para mapear objetos de dominio a DTOs.

# Requisitos
.NET Core 3.1 o superior
Entity Framework Core
AutoMapper
Conexión a Internet para obtener datos de vuelo de la API externa

# Configuración y Uso
1. Clona este repositorio en tu máquina local.

2. Configura la cadena de conexión a la base de datos en appsettings.json.

3. Ejecuta las migraciones de Entity Framework para crear la base de datos:

dotnet ef database update

4. Ejecuta la aplicación:

dotnet run

5. Accede a la API a través de http://localhost:5000/api/externaldata para obtener datos de vuelo externos y http://localhost:5000/api/externaldata/searchjourney para buscar rutas de viaje.

# Contribución
Si deseas contribuir a este proyecto, ¡siéntete libre de hacerlo! Simplemente crea un fork del repositorio, realiza tus cambios y presenta una solicitud de extracción.
