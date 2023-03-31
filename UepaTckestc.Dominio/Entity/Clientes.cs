using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UepaTicksWeb.Dominio.Entity
{
    public partial class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Contactos { get; set; }
        public string Email { get; set; }
        public string PersonaJuridica { get; set; }
        public string PersonaFisica { get; set; }

    }
}
