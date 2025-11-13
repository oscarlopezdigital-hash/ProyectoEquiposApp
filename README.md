# ⚽ Proyecto Equipos MVC (Ejercicio 8.2)

Este proyecto implementa el **Ejercicio Propuesto 8.2** de un listado de equipos y jugadores, utilizando la arquitectura Model-View-Controller (MVC) de ASP.NET Framework.

El objetivo principal es manejar un **Modelo** que contiene una lista de equipos y, para cada equipo, mostrar una tabla con sus jugadores (Nombre, Posición y Edad).

## ✨ Características Implementadas

* **Arquitectura MVC:** Separación clara de responsabilidades entre Modelos (`Equipo`, `Jugador`), Vistas (`Index.cshtml`, `_Layout.cshtml`) y el Controlador (`EquiposController`).
* **Gestión de Datos:** El Controlador instancia una lista estática de equipos con sus respectivos jugadores.
* **Manejo de Nulidad:** Se incluye lógica de C# en la vista Razor para prevenir errores de tipo `NullReferenceException` al iterar sobre equipos o listas de jugadores vacías.
* **Estilismo Moderno:** Se utiliza **Bootstrap 5** a través de su CDN en el archivo `_Layout.cshtml` para aplicar un diseño responsive y moderno (tablas con bandas, tarjetas (`card`), etc.).

## 🚀 Tecnologías Utilizadas

* **Framework:** ASP.NET MVC 5 (o similar)
* **Lenguaje:** C# / Razor
* **Frontend:** HTML5, CSS3, Bootstrap 5 (CDN)
* **Control de Versiones:** Git

## 📂 Estructura del Proyecto (Archivos Clave)

| Archivo | Rol | Descripción |
| :--- | :--- | :--- |
| `EquiposController.cs` | **Controlador** | Crea el Modelo de prueba (`List<Equipo>`) y lo pasa a la Vista. |
| `Equipo.cs` / `Jugador.cs` | **Modelos** | Clases que definen la estructura de los datos. |
| `Views/Shared/_Layout.cshtml` | **Layout** | Estructura principal de la página, incluye el enlace del CDN de Bootstrap. |
| `Views/Equipos/Index.cshtml` | **Vista** | Contiene el bucle principal (`@foreach`) que recorre los equipos y genera las tablas de jugadores con clases de Bootstrap. |

## 🖼️ Resultado (Output)

La aplicación genera una lista iterada de tarjetas (cards) para cada equipo, mostrando sus jugadores en formato de tabla:



---
_Hecho como parte del ejercicio de programación web._
