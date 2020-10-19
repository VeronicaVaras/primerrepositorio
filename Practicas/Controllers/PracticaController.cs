using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practicas.Models;

namespace Practicas.Controllers
{
    public class PracticaController : Controller
    {
        private readonly ILogger<PracticaController> _logger;

        public PracticaController(ILogger<PracticaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

    
       [HttpPost]
        public IActionResult Registrar(Practica1 objPractica){
            if (ModelState.IsValid)
            {
                objPractica.Response = "Gracias por Registrarse";
            }
            return View("index", objPractica);
        }

    }
}
