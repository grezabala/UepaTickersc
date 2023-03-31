using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UepaTicksWeb.Dominio.Dtos
{
    public partial class EventosDto
    {
        [Key]
        public int EventoId { get; set; }
        public string NameEvento { get; set; }
        public string TipoDeEvento { get; set; }
        public int CapacidadTotalDelEvento { get; set; }
        public string LugarDelEvento { get; set; }
        public DateTime FechaDelEvento { get; set; }
        public DateTime HoraDelEvento { get; set; }
    }
}
