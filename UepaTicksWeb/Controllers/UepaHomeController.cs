using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UepaTicksWeb.Models;

namespace UepaTicksWeb.Controllers
{
    public class UepaHomeController : Controller
    {


        private void CargarDropdwon()
        {
            //Este metodo es para cargar los Evento en el dropdwonlist que se presenta en la vista
            List<SelectListItem> listEventos = new()
            {
                new SelectListItem { Value = "AT", Text = "Artes y Tearo" },
                new SelectListItem { Value = "CT", Text = "Concierto" },
                new SelectListItem { Value = "CF", Text = "Conferencia" },
                new SelectListItem { Value = "Ed", Text = "Educativo" },
                new SelectListItem { Value = "Edc", Text = "Educativo" },
                new SelectListItem { Value = "Ev", Text = "Eventos" },
                new SelectListItem { Value = "Inf", Text = "Infaltil " }
            };
            ViewBag.Eventos = listEventos;
        }

        private void CargarDropdownCondicion()
        {
            List<SelectListItem> listCondicion = new()
            {
                new SelectListItem { Value = "OD", Text = "Por orden de llegada" },
                new SelectListItem { Value = "AN", Text = "Asientos numerados" }

            };
            ViewBag.Condicion = listCondicion;
        }

        [HttpGet]
        public IActionResult Index()
        {
            CargarDropdwon();
            CargarDropdownCondicion();

            return View();
        }

        [HttpPost]
        public IActionResult Index(MUepaDatos mUepaDatos)
        {
            /* ESTA ES LA VALIDACION DEL MODELO PARA AGREGAR LO A LA BASE DE DATO
            if (ModelState.IsValid)
            {
                if (Repo.Add(mUepaDatos))
                {
                    return RedirectToAction("Index");
                }
                else
                    ModelState.AddModelError(string.Empty, "Error! El Evento no fue registrado");
                return View(); 
            }
            else
                ModelState.AddModelError("Error!", "Por favor espere en línea un momento");
            return View(mUepaDatos);*/
            return View();
        }
    }

}
