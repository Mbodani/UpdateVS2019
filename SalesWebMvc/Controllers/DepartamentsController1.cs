using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departament> list = new List<Departament>();
            list.Add(new Departament { Id = 1, Name = "Eletronico" });
            list.Add(new Departament { Id = 2, Name = "Fashion" });
            list.Add(new Departament { Id = 3, Name = "Mecânico" });
            return View(list);
        }
    }
}
