using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FORMULARIO.Models;

namespace Formulario.Controllers
{
    public class Formulario : Controller
    {
        private readonly ILogger<Formulario> _logger;

        public Formulario(ILogger<Formulario> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Enviar(Formulario objFormulario){
            objFormulario.Respuesta = "Ya estas registrado" + objFormulario.Nombre;
            return View("index", objFormulario);
        }


    }
}
