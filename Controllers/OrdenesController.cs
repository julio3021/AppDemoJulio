using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AppDemoJulio.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;

namespace AppDemoJulio.Controllers
{
    public class OrdenesController : Controller
    {
        private readonly ILogger<OrdenesController> _logger;

        public OrdenesController(ILogger<OrdenesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["listaOrdenes"] = new List<Ordenes>();
            return View();
        }
        
        public IActionResult Create(Ordenes ordenes)
        {
            List<Ordenes> listaOrdenes = new List<Ordenes>();
            ordenes.CalcularOrden();
            listaOrdenes.Add(ordenes);
            ViewData["listaOrdenes"] = listaOrdenes;
            return View("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }

}