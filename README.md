# API RESTful con Windows Forms y Blazor WebAssembly

## Descripción del proyecto

Este proyecto consiste en el desarrollo e integración de una arquitectura cliente-servidor mediante una API RESTful conectada a una base de datos SQL Server alojada en Azure. La solución incorpora dos aplicaciones cliente desarrolladas con tecnologías diferentes: una aplicación de escritorio utilizando Windows Forms y una aplicación web utilizando Blazor WebAssembly.

La API fue desarrollada utilizando ASP.NET Core Web API y funciona como intermediaria entre las aplicaciones cliente y la base de datos. Para realizar las operaciones de acceso y consulta de información se utiliza Dapper, permitiendo ejecutar consultas SQL de manera eficiente y trabajar con los datos almacenados en SQL Server.

La aplicación Windows Forms consume los servicios de la API mediante `HttpClient`, utilizando operaciones asíncronas con `async/await` para evitar que la interfaz de usuario se bloquee durante las solicitudes. Por otro lado, la aplicación Blazor WebAssembly se comunica con la misma API mediante solicitudes HTTP y presenta los datos obtenidos de la base de datos en una interfaz web.

El proyecto también incorpora la configuración de CORS (Cross-Origin Resource Sharing), necesaria para permitir que la aplicación Blazor WebAssembly pueda comunicarse correctamente con la API RESTful desde un origen diferente.

---

## Objetivo general

Desarrollar y aplicar una arquitectura cliente-servidor mediante la integración de una API RESTful conectada a SQL Server con dos plataformas cliente diferentes: una aplicación de escritorio desarrollada con Windows Forms y una aplicación web desarrollada con Blazor WebAssembly.

---

## Objetivos específicos

- Desarrollar y configurar una API RESTful utilizando ASP.NET Core.
- Conectar la API con una base de datos SQL Server alojada en Azure.
- Utilizar Dapper para realizar operaciones de acceso y consulta de datos.
- Implementar endpoints HTTP para consultar y registrar información.
- Configurar CORS para permitir la comunicación entre la API y la aplicación Blazor WebAssembly.
- Crear una aplicación cliente de escritorio utilizando Windows Forms.
- Diseñar una interfaz gráfica utilizando controles como `TextBox`, `Button` y `DataGridView`.
- Consumir la API desde Windows Forms utilizando `HttpClient`.
- Implementar operaciones asíncronas mediante `async/await` en las solicitudes realizadas desde Windows Forms.
- Crear una aplicación web cliente utilizando Blazor WebAssembly.
- Utilizar `HttpClient` en Blazor para realizar solicitudes a la API.
- Mostrar en las aplicaciones cliente la información almacenada en SQL Server.
- Integrar los diferentes componentes de la solución dentro de una arquitectura cliente-servidor.
- Utilizar Git y GitHub para el control y almacenamiento del código fuente del proyecto.

---

## Arquitectura del sistema

La solución está organizada siguiendo una arquitectura cliente-servidor en la que dos aplicaciones cliente se comunican con una API RESTful, mientras que la API se encarga de acceder a la base de datos.

```text
                    ┌──────────────────────┐
                    │   Windows Forms      │
                    │  Aplicación Desktop  │
                    └──────────┬───────────┘
                               │
                               │ HTTP
                               ▼
                    ┌──────────────────────┐
                    │     ASP.NET Core     │
                    │      Web API         │
                    └──────────┬───────────┘
                               │
                               │ Dapper
                               ▼
                    ┌──────────────────────┐
                    │      Azure SQL       │
                    │     PersonasDB       │
                    └──────────────────────┘
                               ▲
                               │
                               │ HTTP
                    ┌──────────┴───────────┐
                    │ Blazor WebAssembly   │
                    │    Aplicación Web    │
                    └──────────────────────┘
