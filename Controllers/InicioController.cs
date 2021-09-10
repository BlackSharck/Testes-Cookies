using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Zueira.Models;

namespace Zueira.Controllers
{
    public class InicioController: Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}