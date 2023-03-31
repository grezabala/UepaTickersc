using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UepaTicksWeb.Dominio.Entity
{
    public partial class Taquillas
    {
        [Key]
        public int TaquillaId { get; set; }
        public string Seccion { get; set; }
        public decimal PrecioPorTicker { get; set; }
        public int CantidadPorSeccion { get; set; }
        public string Condición { get; set; }

    }
}
