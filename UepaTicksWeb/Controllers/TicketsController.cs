using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UepaTicksWeb.Models;
using System.Linq;

namespace UepaTicksWeb.Controllers
{
    public class TicketsController : Controller
    {
        private  List<Eventos> EventoList;
        
        private List<Eventos> CargarEventos()
        {
            List<Eventos> listEventos = new()
            {
                new Eventos
                {
                    ID = 1,
                    UrlImg = Url.Content("~/img/laure_tn.jpg"),
                    Titulo = "Lauren Jauregui: Live In Concert",
                    Descripcion = "LA ESTRELLA POP LLEGA POR PRIMERA VEZ A RD CON SU NUEVA GIRA INTERNACIONAL !! " +
                                                "MENORES DE EDAD DEBEN SER ACOMPAÑADOS POR UN ADULTO RESPONSABLE.",
                },
                new Eventos
                {
                    ID = 2,
                    UrlImg = Url.Content("~/img/Image5_tn.jpg"),
                    Titulo = "Isle Of Light Music Festival 2023",
                    Descripcion = "Isle of light es una experiencia como ninguna, en un hermoso entorno multicultural con una curación de lo mejor de la música rock, indie, pop y electrónica a nivel mundial mezclado con una diversidad de vendedores artesanales, atractivas instalaciones de arte y selecciones de comida gourmet que representan la intersección del arte, música, y buena onda."
                },
                new Eventos
                {
                    ID = 3,
                    UrlImg = Url.Content("~/img/Imagen3_tn.jpg"),
                    Titulo = "Frank Ceara: Tour entre amigos Funcion Santiago",
                    Descripcion = "Frank Ceara en una noche junto a sus amigos." + "Evento para mayores de 18 años." +
                    "´Este importe no se devuelve.El teatro  cierra sus puertas puntualmente por lo que el derecho de admisión se pierde si se trata de ingresar después de la hora señalada en esta boleta.´"
                },
                new Eventos
                {
                    ID = 4,
                    UrlImg = Url.Content("~/img/Imagen4_tn.jpg"),
                    Titulo = "Tributo Christian Nodal",
                    Descripcion = "Evento Para Mayores De 18 Años."
                },
                new Eventos
                {
                    ID = 5,
                    UrlImg = Url.Content("~/img/Imagen5_tn.jpg"),
                    Titulo = "El Chaval concierto 25 aniversario",
                    Descripcion = "Evento para mayores de 18 años." +
                            "El chaval de la Bachata concierto de su 25 aniversario," +
                              "artistas nacionales e internacionales invitados con una súper producción escénica."
                },
                new Eventos
                {
                    ID = 6,
                    UrlImg = Url.Content("~/img/Imagen6_tn.jpg"),
                    Titulo = "DWE: Desacato",
                    Descripcion = "DWE: Desacato. Evento de lucha libre Dominicana de alto nivel."
                },
                new Eventos
                {
                    ID = 7,
                    UrlImg = Url.Content("~/img/Imagen7_tn.jpg"),
                    Titulo = "Design Week RD 2023",
                    Descripcion = "Con tu boleta podrás acceder a las charlas, exposiciones y experiencias del Design Week RD y MECA. Contamos con 2 tipos de boletas: Day pass (válida por un día), y All Access (Valida para todos los días del evento)." +
                    "Design Week RD Locación: Monumento Fray Antonio de Montesino" +
                    "Meca Locación: Casa Palma" +
                    "Días: 15, 16 y  17 marzo, Horario: 9:00 am - 8:00 p.m." +
                    "Días: 16  y 17 de marzo, Horario: 12:00pm a 8:00pm"
                },
                new Eventos
                {
                    ID = 8,
                    UrlImg = Url.Content("~/img/Imagen8_tn.jpg"),
                    Titulo = "SDQ Gastronómico: Tapas Night",
                    Descripcion = "La entrada incluye la experiencia de los restaurantes participantes en el Restaurant Week 2022." +
                                "Evento para mayores de 18 años."
                },

                new Eventos
                {
                    ID = 9,
                    UrlImg = Url.Content("~/img/Imagen9_tn.jpg"),
                    Titulo = "Francisco Cespedes",
                    Descripcion = "Una noche de pura bohemia con Francisco Céspedes, junto a Carlos Macías y Cristian Allexis.",
                },

                new Eventos
                {
                    ID = 10,
                    UrlImg = Url.Content("~/img/Imagen10_tn.jpg"),
                    Titulo = "Las Cosas Extraordinarias",
                    Descripcion = "Inicia la TEMPORADA DE TEATRO con la obra ¨LAS COSAS EXTRAORDINARIAS¨. Un monólogo interactivo que va construyendo en escena, " +
                    "con la complicidad del público, una historia conmovedora, divertida…"

                },
                new Eventos
                {
                    ID = 11,
                    UrlImg = Url.Content("~/img/Imagen11_tn.jpg"),
                    Titulo = "Nostalgia a piano y voz con Diomary La Mala y el maestro Amaury Sanchez",
                    Descripcion = "Evento para mayores de 18 años",
                },

                new Eventos
                {
                    ID = 12,
                    UrlImg = Url.Content("~/img/Imagen12_tn.jpg"),
                    Titulo = "A reir se ha dicho 2023: Manolo, Liondy y Noel",
                    Descripcion = "Show de humor con Manolo, Liondy y Noel." +
                     "Evento Para Mayores De 18 Años.",
                }

            };

            return listEventos;

        }
        public IActionResult Index(int id)
        {
            EventoList = CargarEventos();
            Eventos evento = EventoList.FirstOrDefault(e => e.ID == id);
            return View(evento);
        }

        public IActionResult ViewIsle() 
        {
            return View();
        }

        public IActionResult ViewFran() 
        {
          return View();
        }

        public IActionResult ViewTributo() 
        {
            return View();
        }

        public IActionResult ViewChaval() 
        {
            return View();
        }

        public IActionResult ViewDWE() 
        {
            return View();
        }

        public IActionResult ViewDiseng() 
        {
            return View();
        }

        public IActionResult ViewSDQ() 
        {
            return View();
        }

        public IActionResult ViewFrancis() 
        {
            return View();
        }

        public IActionResult ViewLasCosa()
        {
            return View();
        }

        public IActionResult ViewNostalgia()
        {
            return View();
        }

        public IActionResult ViewAreir()
        {
            return View();
        }
    }
}
