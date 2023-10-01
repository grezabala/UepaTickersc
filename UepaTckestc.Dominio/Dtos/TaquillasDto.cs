using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UepaTicksWeb.Dominio.Dtos
{
    public partial class TaquillasDto
    {
        [Key]
        public int TaquillaId { get; set; }
        public string Seccion { get; set; }
        public decimal PrecioPorTicker { get; set; }
        public int CantidadPorSeccion { get; set; }
        public string Condición { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsUpdated { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Deleted { get; set; }

        public TaquillasDto()
        {
            IsUpdated = false;
            IsDeleted = false;
            Updated = DateTime.MinValue;
            Deleted = DateTime.MinValue;
        }
    }
}
