using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoEquiposApp.Models
{
    public class Equipo
    {
        public int EquipoId { get; set; }
        public string NombreEquipo { get; set; }
        public List<Jugador> Jugadores { get; set; }
    }
}