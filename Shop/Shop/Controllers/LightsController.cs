using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class LightsController : Controller
    {
        private readonly IAllLights _allLights;
        private readonly ILightCategory _allCategoriers;

        public LightsController(IAllLights iAllLights, ILightCategory iLightsCat) {
            _allLights = iAllLights;
            _allCategoriers = iLightsCat;
        }

        [Route("Lights/List")]
        [Route("Lights/List/{category}")]
        public ViewResult List(string category) {
            string _category = category;
            IEnumerable<Light> lights = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                lights = _allLights.Lights.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("garland", category, StringComparison.OrdinalIgnoreCase))
                {
                    lights = _allLights.Lights.Where(i => i.Categor.categoryName.Equals("Ретро гирлянда")).OrderBy(i => i.id);
                    currCategory = "Ретро гирлянды";
                }
                else if (string.Equals("lamp", category, StringComparison.OrdinalIgnoreCase))
                {
                    lights = _allLights.Lights.Where(i => i.Categor.categoryName.Equals("Ретро светильник")).OrderBy(i => i.id);
                    currCategory = "Електрические светильники";
                }
                else if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    lights = _allLights.Lights.Where(i => i.Categor.categoryName.Equals("Ретро проводка")).OrderBy(i => i.id);
                    currCategory = "Ретро проводка";
                }
            }
            var lightObj = new LightsListViewModel
            {
                allLights = lights,
                lighCategor = currCategory
            };

            ViewBag.Title = "Страница с товарами";

            return View(lightObj);
        }
    }
}
