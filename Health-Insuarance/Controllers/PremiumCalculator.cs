using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Health_Insuarance.Controllers
{
    
    public class PremiumCalculator : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
