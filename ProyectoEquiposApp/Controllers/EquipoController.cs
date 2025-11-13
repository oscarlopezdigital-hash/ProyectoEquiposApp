using ProyectoEquiposApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoEquiposApp.Controllers
{
    public class EquipoController : Controller
    {
        // GET: Equipo
        public ActionResult Index()
        {
            var listaDeEquipos = new List<Equipo>
            {
                new Equipo { EquipoId = 1, NombreEquipo = "Real Madrid", Jugadores = new List<Jugador>
                {
                    new Jugador {Nombre = "Cristiano Ronaldo", Posicion = "Extremo Izquierdo", Edad = 38},
                    new Jugador {Nombre = "Sergio Ramos", Posicion = "Central", Edad = 38},
                    new Jugador {Nombre = "James Rodriguez", Posicion = "Medio ", Edad = 32},
                    new Jugador {Nombre = "Daniel Carvajal", Posicion = "Lateral Derecho", Edad = 34},
                    new Jugador {Nombre = "Karim Benzema", Posicion = "Delantero Centro", Edad = 37}
                }

            },
            new Equipo { EquipoId = 2, NombreEquipo = "Barcelona", Jugadores = new List<Jugador>
                {
                    new Jugador {Nombre = "Lionel Messi", Posicion = "Extremo Derecho", Edad = 36},
                    new Jugador {Nombre = "Sergio Busquets", Posicion = "Medio Centro Defensivo", Edad = 40},
                    new Jugador {Nombre = "Andres Iniesta", Posicion = "Medio Centro ", Edad = 32},
                    new Jugador {Nombre = "Neymar Jr", Posicion = "Extremo Izquierdo", Edad = 34},
                    new Jugador {Nombre = "Luis Suarez", Posicion = "Delantero Centro", Edad = 42}
                }
            },
            new Equipo { EquipoId = 3, NombreEquipo = "Atletico de Madrid", Jugadores = new List<Jugador>
                {
                    new Jugador {Nombre = "Antoine Griezman", Posicion = "Delantero Centro", Edad = 37},
                    new Jugador {Nombre = "Gavi", Posicion = "Defensa Central", Edad = 48},
                    new Jugador {Nombre = "Feranando Torres", Posicion = "Delantero Centro ", Edad = 46},
                    new Jugador {Nombre = "Godin", Posicion = "Central", Edad = 43},
                    new Jugador {Nombre = "Oblak", Posicion = "Portero", Edad = 35}
                }
            }
            };

            return View(listaDeEquipos);
        }
    }
}