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
    public class FormularioController : Controller
    {
        private readonly ILogger<FormularioController> _logger;

            public FormularioController(ILogger<FormularioController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

       [HttpPost]
        public IActionResult Registrar(Formulario objFormulario){

            objFormulario.Response = "Ya estas Registrado" ;
            return View("index", objFormulario);
        }


    }
}