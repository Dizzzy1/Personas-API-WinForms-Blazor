# API Web de Personas (.NET & Dapper)

Este proyecto es una **API Web** desarrollada en **.NET** que implementa un controlador para gestionar el registro de personas. Utiliza **Dapper** como ORM ligero para realizar la persistencia de datos de forma directa en una base de datos **Azure SQL** alojada en la nube.

---

## Tecnologías Utilizadas

* **Framework:** .NET 8.0 / .NET 9.0 (Web API)
* **ORM:** Dapper (Mapeo directo y de alto rendimiento)
* **Base de Datos:** Azure SQL Database (Microsoft Azure)
* **Documentación:** Swagger / OpenAPI
* **Control de Versiones:** Git & GitHub

---

## Requisitos del Proyecto Cumplidos

- [x] **API Web en .NET con controlador:** Implementación de `PersonasController`.
- [x] **Uso de Dapper:** Conexiones y mapeos limpios usando `SqlConnection` y métodos asíncronos.
- [x] **Base de Datos SQL Server:** Instancia configurada y operando en **Azure SQL**.
- [x] **Endpoint funcional:** Endpoint `POST /api/Personas` probado y respondiendo con éxito.
- [x] **Historial de Commits:** Repositorio público con commits ordenados y progresivos.

---

## 📸 Evidencia de Ejecución

A continuación se muestra la captura de pantalla de **Swagger UI** donde se evidencia el envío exitoso de los datos en formato JSON y la respuesta correcta del servidor (**Código 200 OK**):

<img width="1464" height="967" alt="Swagger prueba" src="https://github.com/user-attachments/assets/7c029669-f05b-44d2-a28f-68d641c7e44b" />


A continuación se muestra la captura de pantalla de **Micosoft Azure** donde se evidencia la creacion de la base de datos.

<img width="1747" height="668" alt="Prueba Azure 2" src="https://github.com/user-attachments/assets/6968efce-0b41-4666-b3ff-81ea8cf65328" />

<img width="1919" height="776" alt="Prueba Azure 1" src="https://github.com/user-attachments/assets/f20025a1-24bf-48e6-93e9-a1de174a792a" />
