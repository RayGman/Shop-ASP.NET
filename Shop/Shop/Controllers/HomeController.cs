using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllLights _lightRep;

        public HomeController(IAllLights lightRep)
        {
            _lightRep = lightRep;
        }

        public ViewResult Index() {
            var homeLights = new HomeViewModel
            {
                favLights = _lightRep.getFavLights
            };
            return View(homeLights);
        }
    }
}
