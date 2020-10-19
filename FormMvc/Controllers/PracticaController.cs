using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FormMvc.Models;
using FormMvc.Data;

namespace FormMvc.Controllers
{
    public class PracticaController : Controller
    {
        private readonly ILogger<PracticaController> _logger;
        private readonly DatabaseContext _context;

        public PracticaController(ILogger<PracticaController> logger,
            DatabaseContext context)
        {
            _logger = logger;
            _context=_context;
        }

        public IActionResult Index()
        {
            return View();
        }

    
       [HttpPost]
        public IActionResult Registrar(Practica objPractica){
            if (ModelState.IsValid)
            {
                _context.Add(objPractica);
                _context.SaveChanges();
                objPractica.Response = "Gracias por Registrarse" + objPractica.Nombre;
            }
            return View("index", objPractica);
        }

    }
}
