using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UepaTicksWeb.Models
{
    public class Eventos
    {
        public int ID { get; set; }
        public string UrlImg { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string UrlVista { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
