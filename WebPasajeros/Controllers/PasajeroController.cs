using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using WebPasajeros.Data;
using WebPasajeros.Models;

namespace WebPasajeros.Controllers
{
    public class PasajeroController : Controller
    {
        private readonly PasajeroContext _context;

        public PasajeroController(PasajeroContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Pasajeros.ToList());
        }

        public IActionResult Create()
        {
            Pasajero pasajero = new Pasajero();
            return View("Create", pasajero);
        }

        // POST: /Person/Create
        [HttpPost]
        public IActionResult Create(Pasajero pasajero)
        {
            _context.Add(pasajero);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("/person/ListaPorFecha/{fechaNac}")]
        // GET: /person/ListaPorFecha/
        public IActionResult ListaPorFecha(string fecha)
        {
            var cultureInfo = new CultureInfo("en-US");
            DateTime fechaNac = DateTime.Parse(fecha, cultureInfo, DateTimeStyles.NoCurrentDateDefault);
            List<Pasajero> lista = (from p in _context.Pasajeros
                                  where p.FechaNacimiento == fechaNac
                                  select p).ToList();
            return View("Index", lista);
        }

        [HttpGet("/person/ListaPorCiudad/{city}")]
        // GET: /person/ListaPorCiudad/
        public IActionResult ListaPorCiudad(string ciudad)
        {
            List<Pasajero> lista = (from p in _context.Pasajeros
                                  where p.Ciudad == ciudad
                                  select p).ToList();
            return View("Index", lista);
        }
    }
}
