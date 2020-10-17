using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FormMvc.Models;

namespace FormMvc.Controllers
{
    public class EstudianteController : Controller
    {
        private readonly ILogger<EstudianteController> _logger;

            public EstudianteController(ILogger<EstudianteController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Contacto objEstudiante){
            if (ModelState.IsValid)
            {
                objEstudiante.Response = "Gracias estamos en contacto";
            }
            return View("index", objEstudiante);
        }


    }
}