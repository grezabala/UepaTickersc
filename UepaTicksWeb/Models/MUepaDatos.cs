using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UepaTicksWeb.Models
{
    public class MUepaDatos
    {
        [Display(Name = "Nombre del Evento")]
        public string NombreDelEvento { get; set; }

        [Display(Name = "Lugar del Evento")]
        public string LugarDelEvento { get; set; }

        [Display(Name = "Tipo de Evento")]
        public string TipoDeEvento { get; set; }

        [Display(Name = "Capacidad total a la Venta")]
        public string CapacidadTotalAEvento { get; set; }

        [Display(Name = "Fecha del Evento")]
        public DateTime FechaDelEvento { get; set; }

        [Display(Name = "Hora del Evento")]
        public string HoraDelEvento { get; set; }
        //Datos del Contacto
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        [Display(Name = "Télefono/Celular")]
        public string Contactos { get; set; }

        [Display(Name ="Correo")]
        public string Email { get; set; }

        [Display(Name = "Persona Jurídica")]
        public bool IsPersonaJuridica { get; set; }

        [Display(Name = "Persona Física")]
        public bool IsPersonaFisica { get; set; }
        //Tipo de Taquillas
        public string Seccion { get; set; }
        public decimal Precio { get; set; }
        public int CantidadPorSeccion { get; set; }
        public string Condicion { get; set; }
        public bool IsTipoDeVentaDelEvento { get; set; }
        public bool IsAplicarDescuento { get; set; }
        public bool IsPagoPorCheque { get; set; }
        public string Comentario { get; set; }
        //public bool IsCheckPayment { get; set; }
        //PARA FILTRAR 
        public string FiltroCategorias { get; set; }
        public string FiltroLugares { get; set; }
        public List<Eventos> Eventos { get; set; }
    }
}
