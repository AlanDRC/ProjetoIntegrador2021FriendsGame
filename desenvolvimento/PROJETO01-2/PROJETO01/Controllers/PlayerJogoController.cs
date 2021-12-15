using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO01.Controllers
{
    public class PlayerJogoController : Controller
    {
        public IActionResult Listar()
        {
            return View();
        }
    }
}
