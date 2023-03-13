using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UepaTicksWeb.Models;

namespace UepaTicksWeb.Controllers
{
    public class HomeController : Controller
    {
        private const string V = "Meca Locación: Casa Palma";
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private void DropdownFiltroCategoria()
        {
            List<SelectListItem> listFiltroCategoria = new()
            {
                new SelectListItem { Value = "AT", Text = "Arte y Teatro(15)" },
                new SelectListItem { Value = "A", Text = "Atración (1)" },
                new SelectListItem { Value = "CT", Text = "Conciertos (35)" },
                new SelectListItem { Value = "DP", Text = "Deportes (2)" },
                new SelectListItem { Value = "Ed", Text = "Educativo (1)" },
            };
            ViewBag.Filtro = listFiltroCategoria;
        }

        private void DropdownFiltrarLugares()
        {
            List<SelectListItem> listFiltroLugares = new()
            {

                new SelectListItem { Value = "ASC", Text = "Amazonía Social Club (1)" },
                new SelectListItem { Value = "AACh", Text = "Anfiteatro Alto de Chavón (1)" },
                new SelectListItem { Value = "APT", Text = "Anfiteatro Puerto Plata (1)" },
                new SelectListItem { Value = "AAJR", Text = "Auditorio Alianza Juvenil La Romana (2)" },
                new SelectListItem { Value = "APS", Text = "Auditorio Plaza Sambil" },
                new SelectListItem { Value = "CCU", Text = "Centro de Convenciones y Cultura, Utesa, Santiago (1)" },
                new SelectListItem { Value = "CL", Text = "Colegio Loyola (1)" },
                new SelectListItem { Value = "BSP", Text = "El Barbero De Sevilla, Sala Carlos Piantini (1)" },
                new SelectListItem { Value = "EG", Text = "Escenario 360, Plaza Galeria 360 (2)" },
                new SelectListItem { Value = "GAS", Text = "Gran Arena del Cibao (2)" },

            };
            ViewBag.FiltroLugare = listFiltroLugares;

        }

        //Metodo para mostrar los evento 
        public List<Eventos> CargarEventos()
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
                    UrlVista = Url.Content("~/Tickets/Index")
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

        public IActionResult Index()
        {
            DropdownFiltroCategoria();
            DropdownFiltrarLugares();
            var even = CargarEventos();

            var datosEventos = new MUepaDatos();
            datosEventos.Eventos = even;

            return View(datosEventos);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Ventas() 
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
