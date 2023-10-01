using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UepaTicksWeb.Dominio.Dtos
{
    public partial class ClientesDto
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Contactos { get; set; }
        public string Email { get; set; }
        public string PersonaJuridica { get; set; }
        public string PersonaFisica { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsUpdated { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Deleted { get; set; }

        public ClientesDto()
        {
            IsDeleted = false;
            Updated = DateTime.Now;
            IsUpdated = false;
            Deleted = DateTime.Now;
        }
    }
}
