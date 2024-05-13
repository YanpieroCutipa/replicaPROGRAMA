using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using replicaPROGRAMA.Models;
using replicaPROGRAMA.Data;

namespace replicaPROGRAMA.Controllers
{
    public class ContactoController : Controller
    {
        private readonly ILogger<ContactoController> _logger;
        private readonly ApplicationDbContext _context;


        public ContactoController(ILogger<ContactoController> logger,ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnviarMensaje(Contacto objcontato)
        {
            _logger.LogDebug("INGRESO A ENVIAR MENSAJE");

            //Se registran los datos del objeto a la base datos
            _context.Add(objcontato);
            _context.SaveChanges();

            ViewData["Message"] = "SE REGISTRO EL CONTACTO";
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
