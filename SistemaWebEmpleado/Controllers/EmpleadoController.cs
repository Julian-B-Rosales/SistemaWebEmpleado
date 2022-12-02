using Microsoft.AspNetCore.Mvc;
using SistemaWebEmpleado.Data;
using SistemaWebEmpleado.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaWebEmpleado.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly DBEmpleadosContext _context;

        public EmpleadoController(DBEmpleadosContext context)
        {
            _context = context;
        }
        //GET: Empleado/Index
        public IActionResult Index()
        {
            ViewBag.Fecha = DateTime.Now.ToString();
            return View();
        }

        //GET: Empleado/Todos
        public IActionResult Todos()
        {
            return View("Todos", _context.Empleados.ToList());
        }

        //GET:Empleado/ListarPorTitulo/Abogado
        [HttpGet("/Empleado/ListarPorTitulo/{titulo}")]
        public IActionResult ListarPorTitulo(string titulo)
        {
            List<Empleado> empleados = (from e in _context.Empleados
                                        where e.Titulo == titulo
                                        select e).ToList();

            return View("Todos", empleados);
        }

        //GET: /Empleado/Insertar
        public IActionResult Insertar()
        {
            Empleado empleado = new Empleado();
            return View("Insertar", empleado);
        }

        // POST: /Empleado/Insertar
        [HttpPost]
        public IActionResult Insertar(Empleado empleado)
        {
            _context.Add(empleado);
            _context.SaveChanges();
            return View("Todos", _context.Empleados.ToList());
        }


    }
}
